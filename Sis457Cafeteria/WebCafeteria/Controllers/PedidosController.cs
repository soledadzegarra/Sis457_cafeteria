using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebCafeteria.Models;

namespace WebCafeteria.Controllers
{
    [Authorize]
    public class PedidosController : Controller
    {
        private readonly LabCafeteriaContext _context;

        public PedidosController(LabCafeteriaContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var labCafeteriaContext = _context.Pedidos.Include(p => p.IdClienteNavigation).Include(p => p.IdUsuarioNavigation);
            return View(await labCafeteriaContext.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.IdClienteNavigation)
                .Include(p => p.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pedido == null)
            {
                return NotFound();
            }


            var detalles = await _context.DetallePedidos
                .Include(d => d.IdProductoNavigation)
                .Where(d => d.IdPedido == pedido.Id)
                .ToListAsync();

            ViewBag.Detalles = detalles;


            ViewBag.Total = detalles.Sum(d => d.Total);


            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewBag.Clientes = _context.Clientes.Where(c => c.Estado == 1).ToList();

            ViewBag.Productos = _context.Productos
                .Where(p => p.Estado == 1 && p.Saldo > 0)
                .ToList();
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCliente")] Pedido pedido, string DetalleJson, decimal Total, decimal Efectivo)
        {
            if (string.IsNullOrEmpty(DetalleJson))
            {
                ModelState.AddModelError("", "Debe agregar al menos un producto.");
                CargarListas();
                return View(pedido);
            }

            List<DetallePedidoVM>? detalles;
            try
            {
                detalles = System.Text.Json.JsonSerializer.Deserialize<List<DetallePedidoVM>>(
                    DetalleJson,
                    new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Formato de detalle inválido: " + ex.Message);
                CargarListas();
                return View(pedido);
            }

            if (detalles == null || detalles.Count == 0)
            {
                ModelState.AddModelError("", "Debe agregar al menos un producto.");
                CargarListas();
                return View(pedido);
            }


            // VALIDAR productos y stock ANTES de crear el pedido
            var ids = detalles.Select(d => d.idProducto).Distinct().ToList();
            var productos = await _context.Productos
                .Where(p => ids.Contains(p.Id) && p.Estado == 1)
                .ToDictionaryAsync(p => p.Id);

            foreach (var d in detalles)
            {
                if (!productos.ContainsKey(d.idProducto))
                {
                    ModelState.AddModelError("", $"El producto ID {d.idProducto} ya no existe o está inactivo.");
                    CargarListas();
                    return View(pedido);
                }
                if (d.cantidad > productos[d.idProducto].Saldo)
                {
                    ModelState.AddModelError("", $"Stock insuficiente para '{productos[d.idProducto].Nombre}'. Disponible: {productos[d.idProducto].Saldo}, solicitado: {d.cantidad}.");
                    CargarListas();
                    return View(pedido);
                }
            }

            // Preparar pedido
            pedido.FechaRegistro = DateTime.Now;
            pedido.UsuarioRegistro = User.Identity.Name;
            pedido.Estado = 1;

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Usuario1 == User.Identity.Name);
            if (usuario == null)
            {
                ModelState.AddModelError("", "No se pudo identificar el usuario actual.");
                CargarListas();
                return View(pedido);
            }
            pedido.IdUsuario = usuario.Id;

            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync(); // genera Id y numeroTransaccion

            // Insertar detalles y actualizar stock
            foreach (var d in detalles)
            {
                var producto = productos[d.idProducto];

                _context.DetallePedidos.Add(new DetallePedido
                {
                    IdPedido = pedido.Id,
                    IdProducto = d.idProducto,
                    Cantidad = d.cantidad,
                    PrecioUnitario = d.precioUnitario,
                    Total = d.total,
                    UsuarioRegistro = pedido.UsuarioRegistro,
                    FechaRegistro = DateTime.Now,
                    Estado = 1
                });

                producto.Saldo -= d.cantidad;
                if (producto.Saldo < 0) producto.Saldo = 0;
                _context.Productos.Update(producto);
            }

            await _context.SaveChangesAsync();
            TempData["Mensaje"] = "Pedido guardado correctamente.";

            // REDIRECT para refrescar lista
            return RedirectToAction(nameof(Index));
        }

        // Factoriza carga de listas
        private void CargarListas()
        {
            ViewBag.Clientes = _context.Clientes.Where(c => c.Estado == 1).ToList();
            ViewBag.Productos = _context.Productos.Where(p => p.Estado == 1 && p.Saldo > 0).ToList();
        }

        public class DetallePedidoVM
        {
            public int idProducto { get; set; }          // antes string
            public string nombreProducto { get; set; }
            public int cantidad { get; set; }
            public decimal precioUnitario { get; set; }
            public decimal total { get; set; }
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", pedido.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", pedido.IdUsuario);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdUsuario,IdCliente,NumeroTransaccion,UsuarioRegistro,FechaRegistro,Estado")] Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Id", pedido.IdCliente);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "Id", "Id", pedido.IdUsuario);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.IdClienteNavigation)
                .Include(p => p.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido != null)
            {

                var detalles = _context.DetallePedidos.Where(d => d.IdPedido == id);
                _context.DetallePedidos.RemoveRange(detalles);


                _context.Pedidos.Remove(pedido);

                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
        }
    }
}
