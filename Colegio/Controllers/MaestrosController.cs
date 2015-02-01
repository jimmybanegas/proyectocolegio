using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Colegio.Models;
using IdentitySample.Models;

namespace Colegio.Controllers
{
    public class MaestrosController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Maestros
        public ActionResult Index()
        {
            return View(db.ApplicationUsers.ToList());
        }

        // GET: Maestros/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maestro maestro = db.ApplicationUsers.Find(id);
            if (maestro == null)
            {
                return HttpNotFound();
            }
            return View(maestro);
        }

        // GET: Maestros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maestros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,SegundoNombre,PrimerApellido,SegundoApellido,FechaNacimiento,Sexo,Direccion,NumeroCuenta,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName,Telefono")] Maestro maestro)
        {
            if (ModelState.IsValid)
            {
                db.ApplicationUsers.Add(maestro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maestro);
        }

        // GET: Maestros/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maestro maestro = db.ApplicationUsers.Find(id);
            if (maestro == null)
            {
                return HttpNotFound();
            }
            return View(maestro);
        }

        // POST: Maestros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,SegundoNombre,PrimerApellido,SegundoApellido,FechaNacimiento,Sexo,Direccion,NumeroCuenta,Email,EmailConfirmed,PasswordHash,SecurityStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEndDateUtc,LockoutEnabled,AccessFailedCount,UserName,Telefono")] Maestro maestro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(maestro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maestro);
        }

        // GET: Maestros/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Maestro maestro = db.ApplicationUsers.Find(id);
            if (maestro == null)
            {
                return HttpNotFound();
            }
            return View(maestro);
        }

        // POST: Maestros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Maestro maestro = db.ApplicationUsers.Find(id);
            db.ApplicationUsers.Remove(maestro);
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
