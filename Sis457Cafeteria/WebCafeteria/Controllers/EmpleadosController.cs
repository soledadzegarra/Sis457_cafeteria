using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCafeteria.Models;

namespace WebCafeteria.Controllers
{
    [Authorize]
    public class EmpleadosController : Controller
    {
        private readonly LabCafeteriaContext _context;

        public EmpleadosController(LabCafeteriaContext context)
        {
            _context = context;
        }

        // GET: Empleados
        public async Task<IActionResult> Index()
        {
            var empleados = await _context.Empleados
                .Where(e => e.Estado != -1)
                .ToListAsync();
            return View(empleados);
        }

        // GET: Empleados/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var empleado = await _context.Empleados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empleado == null)
                return NotFound();

            return View(empleado);
        }

        // GET: Empleados/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CedulaIdentidad,Nombres,PrimerApellido,SegundoApellido,Direccion,Celular,Cargo")] Empleado empleado)
        {
            if (!string.IsNullOrEmpty(empleado.CedulaIdentidad) && !string.IsNullOrEmpty(empleado.Nombres))
            {
                empleado.UsuarioRegistro = User.Identity.Name;
                empleado.FechaRegistro = DateTime.Now;
                empleado.Estado = 1;
                _context.Add(empleado);
                await _context.SaveChangesAsync();
                TempData["Mensaje"] = "Empleado agregado exitosamente.";
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado == null)
                return NotFound();

            return View(empleado);
        }

        // POST: Empleados/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CedulaIdentidad,Nombres,PrimerApellido,SegundoApellido,Direccion,Celular,Cargo,UsuarioRegistro,FechaRegistro,Estado")] Empleado empleado)
        {
            if (id != empleado.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    empleado.UsuarioRegistro = User.Identity.Name;
                    _context.Update(empleado);
                    await _context.SaveChangesAsync();
                    TempData["Mensaje"] = "Empleado editado exitosamente.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Empleados.Any(e => e.Id == empleado.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(empleado);
        }

        // GET: Empleados/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var empleado = await _context.Empleados
                .FirstOrDefaultAsync(m => m.Id == id);
            if (empleado == null)
                return NotFound();

            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleado = await _context.Empleados.FindAsync(id);
            if (empleado != null)
            {
                // Baja lógica: solo cambia el estado a -1
                empleado.Estado = -1;
                _context.Update(empleado);
            }
            await _context.SaveChangesAsync();
            TempData["Mensaje"] = "Empleado eliminado correctamente.";
            return RedirectToAction(nameof(Index));
        }

        private bool EmpleadoExists(int id)
        {
            return _context.Empleados.Any(e => e.Id == id);
        }
    }
}