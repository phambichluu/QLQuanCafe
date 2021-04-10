using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLQuanCafe.Models;

namespace QLQuanCafe.Controllers
{
    public class ThanhToanHangNhapsController : Controller
    {
        private QLDbContext db = new QLDbContext();

        // GET: ThanhToanHangNhaps
        public ActionResult Index()
        {
            return View(db.ThanhToanHangNhaps.ToList());
        }

        // GET: ThanhToanHangNhaps/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThanhToanHangNhap thanhToanHangNhap = db.ThanhToanHangNhaps.Find(id);
            if (thanhToanHangNhap == null)
            {
                return HttpNotFound();
            }
            return View(thanhToanHangNhap);
        }

        // GET: ThanhToanHangNhaps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThanhToanHangNhaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTTHangNhap,NgayTT,MaNV,ThanhTien")] ThanhToanHangNhap thanhToanHangNhap)
        {
            if (ModelState.IsValid)
            {
                db.ThanhToanHangNhaps.Add(thanhToanHangNhap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thanhToanHangNhap);
        }

        // GET: ThanhToanHangNhaps/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThanhToanHangNhap thanhToanHangNhap = db.ThanhToanHangNhaps.Find(id);
            if (thanhToanHangNhap == null)
            {
                return HttpNotFound();
            }
            return View(thanhToanHangNhap);
        }

        // POST: ThanhToanHangNhaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTTHangNhap,NgayTT,MaNV,ThanhTien")] ThanhToanHangNhap thanhToanHangNhap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thanhToanHangNhap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thanhToanHangNhap);
        }

        // GET: ThanhToanHangNhaps/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThanhToanHangNhap thanhToanHangNhap = db.ThanhToanHangNhaps.Find(id);
            if (thanhToanHangNhap == null)
            {
                return HttpNotFound();
            }
            return View(thanhToanHangNhap);
        }

        // POST: ThanhToanHangNhaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ThanhToanHangNhap thanhToanHangNhap = db.ThanhToanHangNhaps.Find(id);
            db.ThanhToanHangNhaps.Remove(thanhToanHangNhap);
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
