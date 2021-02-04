using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RentVDB.Models;

namespace RentVDB.Controllers
{
    public class MovieMaysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MovieMays
        public async Task<ActionResult> Index()
        {
            var movieMays = db.MovieMays.Include(m => m.Genre);
            return View(await movieMays.ToListAsync());
        }

        // GET: MovieMays/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieMay movieMay = await db.MovieMays.FindAsync(id);
            if (movieMay == null)
            {
                return HttpNotFound();
            }
            return View(movieMay);
        }

        // GET: MovieMays/Create
        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name");
            return View();
        }

        // POST: MovieMays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,GenreId,DateAdded,ReleaseDate,NumberInStock,NumberAvailable")] MovieMay movieMay)
        {
            if (ModelState.IsValid)
            {
                db.MovieMays.Add(movieMay);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", movieMay.GenreId);
            return View(movieMay);
        }

        // GET: MovieMays/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieMay movieMay = await db.MovieMays.FindAsync(id);
            if (movieMay == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", movieMay.GenreId);
            return View(movieMay);
        }

        // POST: MovieMays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,GenreId,DateAdded,ReleaseDate,NumberInStock,NumberAvailable")] MovieMay movieMay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieMay).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "Id", "Name", movieMay.GenreId);
            return View(movieMay);
        }

        // GET: MovieMays/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieMay movieMay = await db.MovieMays.FindAsync(id);
            if (movieMay == null)
            {
                return HttpNotFound();
            }
            return View(movieMay);
        }

        // POST: MovieMays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            MovieMay movieMay = await db.MovieMays.FindAsync(id);
            db.MovieMays.Remove(movieMay);
            await db.SaveChangesAsync();
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
