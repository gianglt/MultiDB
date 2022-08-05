using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MultiDB.Models;

namespace MultiDB.Controllers
{
    public class DMNhanViensController : Controller
    {
        private DBDieuHanh db;



        public DMNhanViensController()
        {

            // Cannot put SetupDB here, error : Session = null

            //string strDBName = System.Web.HttpContext.Current.Session["dbName"] as string;
            string strDBName = System.Web.HttpContext.Current.Session["dbName"] as string;
            db = new DBDieuHanh(strDBName);
        }
        // GET: DMNhanViens


        //public void SetupDB()
        //{
        //    var nameDB = Session["dbName"] as string;
        //    db = new DBDieuHanh(nameDB);

        //    //db = Session["theDB"] as DBDieuHanh;

        //}
        public ActionResult Index()
        {
            //SetupDB();
            return View(db.DMNhanVien.ToList());
        }

        // GET: DMNhanViens/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DMNhanVien dMNhanVien = db.DMNhanVien.Find(id);
            if (dMNhanVien == null)
            {
                return HttpNotFound();
            }
            return View(dMNhanVien);
        }

        // GET: DMNhanViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DMNhanViens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,HoTen,Ngay_CN")] DMNhanVien dMNhanVien)
        {
            if (ModelState.IsValid)
            {
                db.DMNhanVien.Add(dMNhanVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dMNhanVien);
        }

        // GET: DMNhanViens/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DMNhanVien dMNhanVien = db.DMNhanVien.Find(id);
            if (dMNhanVien == null)
            {
                return HttpNotFound();
            }
            return View(dMNhanVien);
        }

        // POST: DMNhanViens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,HoTen,Ngay_CN")] DMNhanVien dMNhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dMNhanVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dMNhanVien);
        }

        // GET: DMNhanViens/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DMNhanVien dMNhanVien = db.DMNhanVien.Find(id);
            if (dMNhanVien == null)
            {
                return HttpNotFound();
            }
            return View(dMNhanVien);
        }

        // POST: DMNhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            DMNhanVien dMNhanVien = db.DMNhanVien.Find(id);
            db.DMNhanVien.Remove(dMNhanVien);
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
