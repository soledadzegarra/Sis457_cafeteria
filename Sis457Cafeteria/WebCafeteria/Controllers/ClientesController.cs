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
    public class ClientesController : Controller
    {
        private readonly LabCafeteriaContext _context;

        public ClientesController(LabCafeteriaContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            bool existe = await _context.Clientes.AnyAsync(c => c.CedulaIdentidad == cliente.CedulaIdentidad && c.Estado == 1);

            if (existe)
            {
                ModelState.AddModelError("CedulaIdentidad", "Ya existe un cliente con esa cédula de identidad.");
            }
            else
            {
                if (!string.IsNullOrEmpty(cliente.CedulaIdentidad)
                    && !string.IsNullOrEmpty(cliente.Nombres)
                    && !string.IsNullOrEmpty(cliente.Apellidos))
                {
                    cliente.UsuarioRegistro = User.Identity.Name;
                    cliente.FechaRegistro = DateTime.Now;
                    cliente.Estado = 1;
                    _context.Add(cliente);
                    await _context.SaveChangesAsync();
                    TempData["Mensaje"] = "Cliente agregado exitosamente.";
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CedulaIdentidad,Nombres,Apellidos,UsuarioRegistro,FechaRegistro,Estado")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cliente.UsuarioRegistro = User.Identity.Name;
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }

        //otros para formulario de clientes
        [HttpPost]
        public IActionResult CreateQuick(string CedulaIdentidad, string Nombres, string Apellidos)
        {
            if (string.IsNullOrWhiteSpace(CedulaIdentidad) || string.IsNullOrWhiteSpace(Nombres) || string.IsNullOrWhiteSpace(Apellidos))
                return Json(new { success = false, mensaje = "Todos los campos son obligatorios." });

            var existe = _context.Clientes.Any(c => c.CedulaIdentidad == CedulaIdentidad);
            if (existe)
                return Json(new { success = false, mensaje = "Ya existe un cliente con esa cédula." });

            var cliente = new Cliente
            {
                CedulaIdentidad = CedulaIdentidad,
                Nombres = Nombres,
                Apellidos = Apellidos,
                UsuarioRegistro = User.Identity.Name,
                FechaRegistro = DateTime.Now,
                Estado = 1
            };
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return Json(new { success = true, id = cliente.Id, nombres = cliente.Nombres, apellidos = cliente.Apellidos, ci = cliente.CedulaIdentidad });
        }

        //buscador 

    }
}
