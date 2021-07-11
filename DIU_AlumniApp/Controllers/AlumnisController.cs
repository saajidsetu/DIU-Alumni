using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DIU_AlumniApp.Models;

namespace DIU_AlumniApp.Controllers
{

    [Authorize]

    public class AlumnisController : Controller
    {
        private Diu_AlumniDbContext db = new Diu_AlumniDbContext();

        // GET: Alumnis
        public ActionResult Index()
        {

            var list = db.Alumni.ToList();

            if (User.IsInRole("Admin"))
            {
                return View("IndexAdmin",list);
            }

            return View(list);
        }

        // GET: Alumnis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumnis alumnis = db.Alumni.Find(id);
            if (alumnis == null)
            {
                return HttpNotFound();
            }
            return View(alumnis);
        }

        // GET: Alumnis/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Dept,Batch,WP,Phone,Email,FbId")] Alumnis alumnis)
        {
            if (ModelState.IsValid)
            {
                db.Alumni.Add(alumnis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alumnis);
        }

        // GET: Alumnis/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumnis alumnis = db.Alumni.Find(id);
            if (alumnis == null)
            {
                return HttpNotFound();
            }




            return View(alumnis);
        }

        // POST: Alumnis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Dept,Batch,WP,Phone,Email,FbId")] Alumnis alumnis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumnis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alumnis);
        }

        // GET: Alumnis/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumnis alumnis = db.Alumni.Find(id);
            if (alumnis == null)
            {
                return HttpNotFound();
            }
            return View(alumnis);
        }

        // POST: Alumnis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alumnis alumnis = db.Alumni.Find(id);
            db.Alumni.Remove(alumnis);
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
