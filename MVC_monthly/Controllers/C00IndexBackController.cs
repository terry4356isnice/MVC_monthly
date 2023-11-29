using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_monthly.Data;
using MVC_monthly.Models.c00;

namespace MVC_monthly.Controllers
{
    public class C00IndexBackController : Controller
    {
        private MVC_monthlyContext db = new MVC_monthlyContext();

        // GET: C00IndexBack
        public ActionResult Index()
        {
            return View(db.Indices.ToList());
        }

        // GET: C00IndexBack/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Index index = db.Indices.Find(id);
            if (index == null)
            {
                return HttpNotFound();
            }
            return View(index);
        }

        // GET: C00IndexBack/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: C00IndexBack/Create
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TITLE,IMAGE,LINK,ID_2,TITLE_2,IMAGE_2,LINK_2,ID_3,TITLE_3,IMAGE_3,LINK_3")] Index index)
        {
            if (ModelState.IsValid)
            {
                db.Indices.Add(index);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(index);
        }

        // GET: C00IndexBack/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Index index = db.Indices.Find(id);
            if (index == null)
            {
                return HttpNotFound();
            }
            return View(index);
        }

        // POST: C00IndexBack/Edit/5
        // 若要避免過量張貼攻擊，請啟用您要繫結的特定屬性。
        // 如需詳細資料，請參閱 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TITLE,IMAGE,LINK,ID_2,TITLE_2,IMAGE_2,LINK_2,ID_3,TITLE_3,IMAGE_3,LINK_3")] Index index)
        {
            if (ModelState.IsValid)
            {
                db.Entry(index).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(index);
        }

        // GET: C00IndexBack/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Index index = db.Indices.Find(id);
            if (index == null)
            {
                return HttpNotFound();
            }
            return View(index);
        }

        // POST: C00IndexBack/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Index index = db.Indices.Find(id);
            db.Indices.Remove(index);
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
