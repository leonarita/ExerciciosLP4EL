using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Controllers
{
    public class EditoraController : Controller
    {
        private LivrariaContexto contexto;

        public EditoraController(LivrariaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await contexto.Editora.OrderBy(e => e.Nome).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Site")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                contexto.Editora.Add(editora);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(editora);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
                return NotFound("Editora com Id nulo.");

            var editora = await contexto.Editora.FindAsync(id);

            if (editora == null)
                return NotFound("Editora com Id = " + id + " não foi encontrada.");

            return View(editora);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("EditoraId,Nome,Site")] Editora editora)
        {
            if (ModelState.IsValid)
            {
                contexto.Editora.Update(editora);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(editora);
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
                return NotFound("Editora com Id nulo.");

            var editora = await contexto.Editora.FindAsync(id);

            if (editora == null)
                return NotFound("Editora com Id = " + id + " não foi encontrada.");

            return View(editora);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var editora = await contexto.Editora.FindAsync(id);

            try
            {
                contexto.Editora.Remove(editora);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch
            {
                return BadRequest("Não foi possível efetuar a exclusão");
            }
        }
    }
}
