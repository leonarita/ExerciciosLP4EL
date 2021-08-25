using ProjetoPesquisaEstabelecimentoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Controllers
{
    public class EstabelecimentoController : Controller
    {
        private PesquisaEstabelecimentoHospedagemDBEntities db = new PesquisaEstabelecimentoHospedagemDBEntities();

        public ActionResult Index()
        {
            var estabelecimentos = db.Estabelecimento.Include("Cidade").Include("Categoria").ToList();
            return View(estabelecimentos);
        }

        public ActionResult Inserir()
        {
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Inserir(Estabelecimento estabelecimento)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Estabelecimento.Add(estabelecimento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        public ActionResult Alterar(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        [HttpPost]
        public ActionResult Alterar(Estabelecimento estabelecimento)
        {
            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;

            if (ModelState.IsValid)
            {
                db.Entry(estabelecimento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        public ActionResult Excluir(int id)
        {
            Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
            ViewBag.IdCategoria = new SelectList(db.Categoria, "IdCategoria", "Descricao", estabelecimento.IdCategoria);
            ViewBag.IdCidade = new SelectList(db.Cidade, "IdCidade", "Nome", estabelecimento.IdCidade);
            return View(estabelecimento);
        }

        [HttpPost, ActionName("Excluir")]
        public ActionResult EfetuarExclusão(int id)
        {
            try
            {
                Estabelecimento estabelecimento = db.Estabelecimento.Find(id);
                db.Estabelecimento.Remove(estabelecimento);
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