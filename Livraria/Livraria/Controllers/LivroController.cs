using Livraria.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Controllers
{
    public class LivroController : Controller
    {
        private LivrariaContexto contexto;

        public LivroController(LivrariaContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<IActionResult> Index()
        {
            return View(await contexto.Livro.Include(e => e.Editora).OrderBy(l => l.Titulo).ToListAsync());
        }

        public IActionResult Create()
        {
            var editoras = contexto.Editora.OrderBy(i => i.Nome).ToList();

            editoras.Insert(0, new Editora()
            {
                EditoraId = 0,
                Nome = "Selecione a Editora"
            });

            ViewBag.EditoraId = new SelectList(editoras, "EditoraId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Titulo,Preco,Disponivel,EditoraId")] Livro livro)
        {
            if(ModelState.IsValid)
            {
                contexto.Livro.Add(livro);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EditoraId = new SelectList(contexto.Editora, "EditoraId", "Nome", livro.EditoraId);
            return View(livro);
        }

        public async Task<IActionResult> Edit(long? id)
        {
            if(id == null)
                return NotFound("Livro com Id nulo.");

            var livro = await contexto.Livro.FindAsync(id);

            if(livro == null)
                return NotFound("Livro com Id = " + id + " não foi encontrado.");

            ViewBag.EditoraId = new SelectList(contexto.Editora, "EditoraId", "Nome", livro.EditoraId);
            return View(livro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([Bind("LivroId,Titulo,Preco,Disponivel,EditoraId")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                contexto.Livro.Update(livro);
                await contexto.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.EditoraId = new SelectList(contexto.Editora, "EditoraId", "Nome", livro.EditoraId);
            return View(livro);
        }

        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
                return NotFound("Livro com Id nulo.");

            var livro = await contexto.Livro.FindAsync(id);

            if (livro == null)
                return NotFound("Livro com Id = " + id + " não foi encontrado.");

            contexto.Editora.Where(e => e.EditoraId == livro.EditoraId).Load();
            return View(livro);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long? id)
        {
            var livro = await contexto.Livro.FindAsync(id);

            try
            {
                contexto.Livro.Remove(livro);
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
