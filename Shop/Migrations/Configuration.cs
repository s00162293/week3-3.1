namespace Shop.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop.Models.RepoPatternContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //everytime models change it will scaffoled up
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Shop.Models.RepoPatternContext context)
        {
            var users = new List<User>
            {
                new User() {  Username ="ngannon", Balance=200 },
                new User() {  Username ="jsmith", Balance=100 },
                new User() {  Username ="sdoe", Balance=1000 },
                new User() {  Username ="milly", Balance=750 }
             };
            var Items = new List<ShopItem>
            {
                  new ShopItem() {  Name ="Small Heath", Cost=100, Class=ItemClass.Heath, ImageURL="~/Content/Images/health_icon.png" },
                  new ShopItem() {  Name ="Big Heath",   Cost=50, Class=ItemClass.Heath, ImageURL="~/Content/Images/health_icon.png" },
                  new ShopItem() {  Name ="Small Magic", Cost=100, Class=ItemClass.Magic, ImageURL="~/Content/Images/magic_icon.png" },
                  new ShopItem() {  Name ="Big Magic",   Cost=50, Class=ItemClass.Magic, ImageURL="~/Content/Images/magic_icon.png" },
                  new ShopItem() {  Name ="Small Stamina", Cost=100, Class=ItemClass.Stamina, ImageURL="~/Content/Images/stamina_icon.png" },
                  new ShopItem() {  Name ="Big Stamina", Cost=50, Class=ItemClass.Stamina, ImageURL="~/Content/Images/stamina_icon.png" },

            };

            users.ForEach(u => context.Users.Add(u));
            Items.ForEach(i => context.ShopItems.Add(i));

            context.SaveChanges();

        }
    }
}
