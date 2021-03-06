﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public enum ItemClass
    {
        Heath,
        Magic,
        Stamina
    }
    public class ShopItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public ItemClass Class { get; set; }
        public string ImageURL { get; set; }
    }
}