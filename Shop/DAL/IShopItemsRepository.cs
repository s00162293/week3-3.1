using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL
{
    interface IShopItemsRepository
    {
        IEnumerable<ShopItem> GetItems();
        ShopItem GetItemByID(int itemID);

        void InsertItem(ShopItem item);
        void UpdateItem(ShopItem item);
        void DeleteItem(int itemID);
        void Save();
        
    }
}
