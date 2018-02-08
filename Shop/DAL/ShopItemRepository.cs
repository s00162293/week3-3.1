using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop.Models;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;

namespace Shop.DAL
{
    public class ShopItemRepository : IShopItemsRepository, IDisposable
    {
        RepoPatternContext context;

        public ShopItemRepository(RepoPatternContext context)
        {
            this.context = context;
        }

        public void DeleteItem(int itemID)
        {
            ShopItem shopItem = context.ShopItems.Find(itemID);
            context.ShopItems.Remove(shopItem);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public ShopItem GetItemByID(int itemID)
        {
            return context.ShopItems.Find(itemID);           
        }

        public IEnumerable<ShopItem> GetItems()
        {
            return context.ShopItems.ToList();
        }

        public void InsertItem(ShopItem item)
        {
           context.ShopItems.Add(item);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateItem(ShopItem item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}