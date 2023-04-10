using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using STDBind;

namespace STDBind.Controllers
{
    public class StudentController : Controller
    {
        private StudentDbEntities1 db = new StudentDbEntities1();

        // GET: Student
        public ActionResult Index(int? id,string searchBy,string search)
        {
            var query = db.Student_tbl.AsQueryable();
            if (id.HasValue)
            {
                var studentId = id.Value;
                query = query.Where(d => d.ID == studentId);
                var searchid = query.ToList();
                return View("index", searchid);
            }
            /*return View(db.Student_tbl.Where(x => x.Name.Contains(search) || search == null).ToList()) ;*/
            else if (searchBy == "Name")
            {
                var data = db.Student_tbl.Where(d => d.Name.StartsWith(search)).ToList();
                return View(data.ToList());
            }
            else if (searchBy == "Email")
            {
                var data = db.Student_tbl.Where(d => d.Email.StartsWith(search)).ToList();
                return View(data.ToList());
            }
            else
            {
                var data = db.Student_tbl.ToList();
                return View(data);
            }
        }

        // GET: Student/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_tbl student_tbl = db.Student_tbl.Find(id);
            if (student_tbl == null)
            {
                return HttpNotFound();
            }
            return View(student_tbl);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Email,phone_number")] Student_tbl student_tbl,Student_tbl s)
        {
            if (ModelState.IsValid)
            {
                db.Student_tbl.Add(student_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            string filename = Path.GetFileNameWithoutExtension(s.PdfFile.FileName);
            string extension = Path.GetExtension(s.PdfFile.FileName);
            filename = filename + extension; 
            return View(student_tbl);
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_tbl student_tbl = db.Student_tbl.Find(id);
            if (student_tbl == null)
            {
                return HttpNotFound();
            }
            return View(student_tbl);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Email,phone_number")] Student_tbl student_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student_tbl);
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student_tbl student_tbl = db.Student_tbl.Find(id);
            if (student_tbl == null)
            {
                return HttpNotFound();
            }
            return View(student_tbl);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student_tbl student_tbl = db.Student_tbl.Find(id);
            db.Student_tbl.Remove(student_tbl);
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
