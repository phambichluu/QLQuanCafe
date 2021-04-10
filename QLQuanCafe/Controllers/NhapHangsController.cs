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
    public class NhapHangsController : Controller
    {
        private QLDbContext db = new QLDbContext();

        // GET: NhapHangs
        public ActionResult Index()
        {
            return View(db.NhapHangs.ToList());
        }

        // GET: NhapHangs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhapHang nhapHang = db.NhapHangs.Find(id);
            if (nhapHang == null)
            {
                return HttpNotFound();
            }
            return View(nhapHang);
        }

        // GET: NhapHangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhapHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaNhapHang,NgayNhapHang,LoaiHangHoa,DonGia,SoLuong,ThanhTien")] NhapHang nhapHang)
        {
            if (ModelState.IsValid)
            {
                db.NhapHangs.Add(nhapHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhapHang);
        }

        // GET: NhapHangs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhapHang nhapHang = db.NhapHangs.Find(id);
            if (nhapHang == null)
            {
                return HttpNotFound();
            }
            return View(nhapHang);
        }

        // POST: NhapHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaNhapHang,NgayNhapHang,LoaiHangHoa,DonGia,SoLuong,ThanhTien")] NhapHang nhapHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhapHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhapHang);
        }

        // GET: NhapHangs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhapHang nhapHang = db.NhapHangs.Find(id);
            if (nhapHang == null)
            {
                return HttpNotFound();
            }
            return View(nhapHang);
        }

        // POST: NhapHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NhapHang nhapHang = db.NhapHangs.Find(id);
            db.NhapHangs.Remove(nhapHang);
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
