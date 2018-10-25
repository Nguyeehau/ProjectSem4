namespace ShopBug.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShopBug.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopBug.Data.ShopBugDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopBug.Data.ShopBugDbContext context)
        {
            CreateProductCategory(context);
            //var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopBugDbContext()));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopBugDbContext()));

            //var user = new ApplicationUser()
            //{
            //    UserName = "Giang",
            //    Email = "giangpvd00294@fpt.edu.vn",
            //    EmailConfirmed = true,
            //    BirthDay = DateTime.Now,
            //    FullName = "Phan Văn Giang"

            //};

            //manager.Create(user, "123654$");

            //if (!roleManager.Roles.Any())
            //{
            //    roleManager.Create(new IdentityRole { Name = "Admin" });
            //    roleManager.Create(new IdentityRole { Name = "User" });
            //}

            //var adminUser = manager.FindByEmail("giangpvd00294@fpt.edu.vn");

            //manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });

        }
        private void CreateProductCategory(ShopBug.Data.ShopBugDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> productCategories = new List<ProductCategory>()
            {
                new ProductCategory(){Name="Điện lạnh", Alias="dien-lanh",Status=true},
                new ProductCategory(){Name="Đồ gia dụng ", Alias="do-gia-dung",Status=true},
            };
                context.ProductCategories.AddRange(productCategories);
                context.SaveChanges();
            }
        }
       
    }
}
