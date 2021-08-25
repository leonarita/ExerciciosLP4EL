using ProjetoPesquisaEstabelecimentoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Controllers
{
    [OutputCache(Location = System.Web.UI.OutputCacheLocation.None, NoStore = true)]
    public class CidadeController : Controller
    {
        private PesquisaEstabelecimentoHospedagemDBEntities db = new PesquisaEstabelecimentoHospedagemDBEntities();

        public ActionResult Index()
        {
            var cidades = db.Cidade.ToList();
            return View(cidades);
        }

        public ActionResult Inserir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Cidade cidade)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            cidade.IdCidade = 0;

            if (ModelState.IsValid)
            {
                db.Cidade.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        public ActionResult Alterar(int id)
        {
            Cidade cidade = db.Cidade.Find(id);
            return View(cidade);
        }

        [HttpPost]
        public ActionResult Alterar(Cidade cidade)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        public ActionResult Excluir(int id)
        {
            Cidade cidade = db.Cidade.Find(id);
            return View(cidade);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                Cidade cidade = db.Cidade.Find(id);
                db.Cidade.Remove(cidade);
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