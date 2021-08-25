using ProjetoPesquisaEstabelecimentoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Controllers
{
    [OutputCache(Location = OutputCacheLocation.None, NoStore = true)]
    public class CategoriaController : Controller
    {
        private PesquisaEstabelecimentoHospedagemDBEntities db = new PesquisaEstabelecimentoHospedagemDBEntities();

        public ActionResult Index()
        {
            var categorias = db.Categoria.ToList();
            return View(categorias);
        }

        public ActionResult Inserir()
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Categoria categoria)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Categoria.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Alterar(int id)
        {
            Categoria categoria = db.Categoria.Find(id);
            return View(categoria);
        }

        [HttpPost]
        public ActionResult Alterar(Categoria categoria)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Excluir(int id)
        {
            Categoria categoria = db.Categoria.Find(id);
            return View(categoria);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                Categoria categoria = db.Categoria.Find(id);
                db.Categoria.Remove(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("ErroExcluir");
            }
        }

        public ActionResult ErroExcluir()
        {
            return View();
        }

    }
}