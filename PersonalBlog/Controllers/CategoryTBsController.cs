using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataModel;

namespace PersonalBlog.Controllers
{
    public class CategoryTBsController : Controller
    {
        private ContentDBEntities db = new ContentDBEntities();

        // GET: CategoryTBs
        public ActionResult Index()
        {
            return View(db.CategoryTB.ToList());
        }

        // GET: CategoryTBs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryTB categoryTB = db.CategoryTB.Find(id);
            if (categoryTB == null)
            {
                return HttpNotFound();
            }
            return View(categoryTB);
        }

        // GET: CategoryTBs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryTBs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CategoryID,CategoryName,ParentID,IndexOrder,CreatedDate,Status,LargeIcon,Icon,ClientType,ClientVersion,HasList,IsLocal,LayoutType,CategoryFrom,ChildrenCount,JumpType,JumpUrl,Description,AppDownloadUrl,FeedbackUrl,OriginalID,Priority,Jpop,Bdefault,ShowToolBar,StatusBarStyle,CacheMinutes,LastModifiedDate,WebViewStyle,MainClickShowContent,ListClickShowContent,ListShowDownloadIcon,AppScheme,AppVersion,BackgroundImg,CheckStatus,CategoryType,RemindType,IpPort,DayShareUrl,MonthShareUrl,DateType,CategoryStartDate,CategoryEndDate,CategoryPre,CategoryAfter,Chosen_circle_color,MonthDateChosen_color,MonthTitle_color,Item_point_color,ShowBackAndShare,KeyDateTime,KeyString,itemHeaderBgColor,ContentTypeIcon,DefaultReminder,hascity")] CategoryTB categoryTB)
        {
            if (ModelState.IsValid)
            {
                db.CategoryTB.Add(categoryTB);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoryTB);
        }

        // GET: CategoryTBs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryTB categoryTB = db.CategoryTB.Find(id);
            if (categoryTB == null)
            {
                return HttpNotFound();
            }
            return View(categoryTB);
        }

        // POST: CategoryTBs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CategoryID,CategoryName,ParentID,IndexOrder,CreatedDate,Status,LargeIcon,Icon,ClientType,ClientVersion,HasList,IsLocal,LayoutType,CategoryFrom,ChildrenCount,JumpType,JumpUrl,Description,AppDownloadUrl,FeedbackUrl,OriginalID,Priority,Jpop,Bdefault,ShowToolBar,StatusBarStyle,CacheMinutes,LastModifiedDate,WebViewStyle,MainClickShowContent,ListClickShowContent,ListShowDownloadIcon,AppScheme,AppVersion,BackgroundImg,CheckStatus,CategoryType,RemindType,IpPort,DayShareUrl,MonthShareUrl,DateType,CategoryStartDate,CategoryEndDate,CategoryPre,CategoryAfter,Chosen_circle_color,MonthDateChosen_color,MonthTitle_color,Item_point_color,ShowBackAndShare,KeyDateTime,KeyString,itemHeaderBgColor,ContentTypeIcon,DefaultReminder,hascity")] CategoryTB categoryTB)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoryTB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoryTB);
        }

        // GET: CategoryTBs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoryTB categoryTB = db.CategoryTB.Find(id);
            if (categoryTB == null)
            {
                return HttpNotFound();
            }
            return View(categoryTB);
        }

        // POST: CategoryTBs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoryTB categoryTB = db.CategoryTB.Find(id);
            db.CategoryTB.Remove(categoryTB);
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
