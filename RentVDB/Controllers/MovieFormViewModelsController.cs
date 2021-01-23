using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentVDB.Models;

namespace RentVDB.Controllers
{
    public class MovieFormViewModelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MovieFormViewModels
        public ActionResult Index()
        {
            return View(db.MovieFormViewModels.ToList());
        }

        // GET: MovieFormViewModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieFormViewModel movieFormViewModel = db.MovieFormViewModels.Find(id);
            if (movieFormViewModel == null)
            {
                return HttpNotFound();
            }
            return View(movieFormViewModel);
        }

        // GET: MovieFormViewModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieFormViewModels/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,GenreId,ReleaseDate,NumberInStock")] MovieFormViewModel movieFormViewModel)
        {
            if (ModelState.IsValid)
            {
                db.MovieFormViewModels.Add(movieFormViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieFormViewModel);
        }

        // GET: MovieFormViewModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieFormViewModel movieFormViewModel = db.MovieFormViewModels.Find(id);
            if (movieFormViewModel == null)
            {
                return HttpNotFound();
            }
            return View(movieFormViewModel);
        }

        // POST: MovieFormViewModels/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,GenreId,ReleaseDate,NumberInStock")] MovieFormViewModel movieFormViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieFormViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieFormViewModel);
        }

        // GET: MovieFormViewModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieFormViewModel movieFormViewModel = db.MovieFormViewModels.Find(id);
            if (movieFormViewModel == null)
            {
                return HttpNotFound();
            }
            return View(movieFormViewModel);
        }

        // POST: MovieFormViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieFormViewModel movieFormViewModel = db.MovieFormViewModels.Find(id);
            db.MovieFormViewModels.Remove(movieFormViewModel);
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
