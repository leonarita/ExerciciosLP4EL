using ProjetoPesquisaEstabelecimentoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Controllers
{
    public class TipoQuartoController : Controller
    {
        private PesquisaEstabelecimentoHospedagemDBEntities db = new PesquisaEstabelecimentoHospedagemDBEntities();

        public ActionResult Index()
        {
            var tipoQuartos = db.TipoQuarto.ToList();
            return View(tipoQuartos);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(TipoQuarto tipoQuarto)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.TipoQuarto.Add(tipoQuarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoQuarto);
        }

        public ActionResult Alterar(int id)
        {
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            return View(tipoQuarto);
        }

        [HttpPost]
        public ActionResult Alterar(TipoQuarto tipoQuarto)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Entry(tipoQuarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoQuarto);
        }

        public ActionResult Excluir(int id)
        {
            TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
            return View(tipoQuarto);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                TipoQuarto tipoQuarto = db.TipoQuarto.Find(id);
                db.TipoQuarto.Remove(tipoQuarto);
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