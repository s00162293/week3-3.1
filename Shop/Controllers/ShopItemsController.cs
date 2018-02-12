using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Shop.Models;
using Shop.DAL;

namespace Shop.Controllers
{
    public class ShopItemsController : Controller
    {
        private IShopItemsRepository shopRepo;

        public ShopItemsController()
        {
            shopRepo = new ShopItemRepository(new RepoPatternContext());
        }
        //private RepoPatternContext db = new RepoPatternContext();



        //// GET: ShopItems
        public ActionResult Index()
        {
            return View(shopRepo.GetItems());
        }

        // GET: ShopItems/Details/5
        public ActionResult Details(int id)
        {
            return View(shopRepo.GetItemByID(id));
        }

        // GET: ShopItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Name,Cost,Class,ImageURL")] ShopItem shopItem)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.ShopItems.Add(shopItem);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(shopItem);
        //}

        //// GET: ShopItems/Edit/5
        public ActionResult Edit(int id)
        {
            return View(shopRepo.GetItemByID(id));
        }

        //// POST: ShopItems/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Name,Cost,Class,ImageURL")] ShopItem shopItem)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(shopItem).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(shopItem);
        //}

        //// GET: ShopItems/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    return View(shopRepo.DeleteItem(id));
        //}

        //// POST: ShopItems/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    return View(shopRepo.DeleteItem(id));
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
