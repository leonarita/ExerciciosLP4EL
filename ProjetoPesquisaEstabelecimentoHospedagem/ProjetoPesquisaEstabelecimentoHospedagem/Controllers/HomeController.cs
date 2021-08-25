using ProjetoPesquisaEstabelecimentoHospedagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPesquisaEstabelecimentoHospedagem.Controllers
{
    public class HomeController : Controller
    {
        private PesquisaEstabelecimentoHospedagemDBEntities db = new PesquisaEstabelecimentoHospedagemDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Categoria = new SelectList(db.Categoria, "IdCategoria", "Descricao");
            ViewBag.Cidade = new SelectList(db.Cidade, "IdCidade", "Nome");

            return View();
        }

        public ActionResult Pesquisar(Pesquisa pesquisa)
        {
            var restaurantes = from e in db.Estabelecimento
                               where e.IdCategoria == pesquisa.IdCategoria && e.IdCidade == pesquisa.IdCidade
                               select new ResultadoPesquisa
                               {
                                   NomeComercial = e.NomeComercial,
                                   RazaoSocial = e.RazaoSocial,
                                   Telefone = e.Telefone,
                                   Endereco = e.Endereco,
                                   Site = e.Site
                               };

            return Json(restaurantes, JsonRequestBehavior.AllowGet);
        }
    }
}