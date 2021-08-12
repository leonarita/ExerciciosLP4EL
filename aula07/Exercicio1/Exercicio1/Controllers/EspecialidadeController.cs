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
    public class EspecialidadeController : Controller
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        // GET: Especialidade
        public ActionResult Index()
        {
            return View(db.Especialidade.ToList());
        }

        // GET: Especialidade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Especialidade especialidade = db.Especialidade.Find(id);
            if (especialidade == null)
            {
                return HttpNotFound();
            }
            return View(especialidade);
        }

        // GET: Especialidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Especialidade/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEspecialidade,Descricao")] Especialidade especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Especialidade.Add(especialidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(especialidade);
        }

        // GET: Especialidade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Especialidade especialidade = db.Especialidade.Find(id);
            if (especialidade == null)
            {
                return HttpNotFound();
            }
            return View(especialidade);
        }

        // POST: Especialidade/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEspecialidade,Descricao")] Especialidade especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(especialidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(especialidade);
        }

        // GET: Especialidade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Especialidade especialidade = db.Especialidade.Find(id);
            if (especialidade == null)
            {
                return HttpNotFound();
            }
            return View(especialidade);
        }

        // POST: Especialidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Especialidade especialidade = db.Especialidade.Find(id);
            db.Especialidade.Remove(especialidade);
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
