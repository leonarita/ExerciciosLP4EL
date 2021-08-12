using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exercicio1.Models;

namespace Exercicio1.Controllers
{
    public class MedicoController : Controller
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        // GET: Medico
        public ActionResult Index()
        {
            var medico = db.Medico.Include(m => m.Especialidade);
            return View(medico.ToList());
        }

        // GET: Medico/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medico medico = db.Medico.Find(id);
            if (medico == null)
            {
                return HttpNotFound();
            }
            return View(medico);
        }

        // GET: Medico/Create
        public ActionResult Create()
        {
            ViewBag.IdEspecialidade = new SelectList(db.Especialidade, "IdEspecialidade", "Descricao");
            return View();
        }

        // POST: Medico/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMedico,Nome,CRM,Endereco,Telefone,Email,IdEspecialidade")] Medico medico)
        {
            if (ModelState.IsValid)
            {
                db.Medico.Add(medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEspecialidade = new SelectList(db.Especialidade, "IdEspecialidade", "Descricao", medico.IdEspecialidade);
            return View(medico);
        }

        // GET: Medico/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medico medico = db.Medico.Find(id);
            if (medico == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEspecialidade = new SelectList(db.Especialidade, "IdEspecialidade", "Descricao", medico.IdEspecialidade);
            return View(medico);
        }

        // POST: Medico/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMedico,Nome,CRM,Endereco,Telefone,Email,IdEspecialidade")] Medico medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEspecialidade = new SelectList(db.Especialidade, "IdEspecialidade", "Descricao", medico.IdEspecialidade);
            return View(medico);
        }

        // GET: Medico/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Medico medico = db.Medico.Find(id);
            if (medico == null)
            {
                return HttpNotFound();
            }
            return View(medico);
        }

        // POST: Medico/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Medico medico = db.Medico.Find(id);
            db.Medico.Remove(medico);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
