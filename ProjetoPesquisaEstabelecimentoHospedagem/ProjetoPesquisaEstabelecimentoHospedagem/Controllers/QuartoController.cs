using ProjetoPesquisaEstabelecimentoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Controllers
{
    public class QuartoController : Controller
    {
        private PesquisaEstabelecimentoHospedagemDBEntities db = new PesquisaEstabelecimentoHospedagemDBEntities();

        public ActionResult Index()
        {
            var quartos = db.Quarto.Include("Estabelecimento").Include("TipoQuarto").ToList();
            return View(quartos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Quarto quarto)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Quarto.Add(quarto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View(quarto);
        }

        public ActionResult Alterar(int id)
        {
            Quarto quarto = db.Quarto.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View(quarto);
        }

        [HttpPost]
        public ActionResult Alterar(Quarto quarto)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Entry(quarto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View(quarto);
        }

        public ActionResult Excluir(int id)
        {
            Quarto quarto = db.Quarto.Find(id);
            ViewBag.IdEstabelecimento = new SelectList(db.Estabelecimento, "IdEstabelecimento", "NomeComercial");
            ViewBag.IdTipoQuarto = new SelectList(db.TipoQuarto, "IdTipoQuarto", "Descricao");
            return View(quarto);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                Quarto quarto = db.Quarto.Find(id);
                db.Quarto.Remove(quarto);
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

        public ActionResult VerificaSeNumeroQuartoNaoExiste(int idEstabelecimento, int numeroQuarto)
        {
            var quarto = db.Quarto.Where(q => q.IdEstabelecimento == idEstabelecimento && q.NumeroQuarto == numeroQuarto).FirstOrDefault();

            if (quarto != null)
                return Json(false, JsonRequestBehavior.AllowGet);
            else
                return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}