using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CCTokenSystem.Models;

namespace CCTokenSystem.Controllers
{
    public class Departments1Controller : Controller
    {
        private CCTokenSystemContext db = new CCTokenSystemContext();

        // GET: Departments1
        public ActionResult Index()
        {
            var departments = db.Departments.Include(d => d.Campuses);
            return View(departments.ToList());
        }

        // GET: Departments1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // GET: Departments1/Create
        public ActionResult Create()
        {
            ViewBag.CampusId = new SelectList(db.Campuses, "CampusId", "CampusName");
            return View();
        }

        // POST: Departments1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DeptId,DeptName,Advisor_Fname,Advisor_Lname,Email,ContactNo,Extension,CampusId")] Department department)
        {
            if (ModelState.IsValid)
            {
                db.Departments.Add(department);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CampusId = new SelectList(db.Campuses, "CampusId", "CampusName", department.CampusId);
            return View(department);
        }

        // GET: Departments1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            ViewBag.CampusId = new SelectList(db.Campuses, "CampusId", "CampusName", department.CampusId);
            return View(department);
        }

        // POST: Departments1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DeptId,DeptName,Advisor_Fname,Advisor_Lname,Email,ContactNo,Extension,CampusId")] Department department)
        {
            if (ModelState.IsValid)
            {
                db.Entry(department).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CampusId = new SelectList(db.Campuses, "CampusId", "CampusName", department.CampusId);
            return View(department);
        }

        // GET: Departments1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = db.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Departments1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Department department = db.Departments.Find(id);
            db.Departments.Remove(department);
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
