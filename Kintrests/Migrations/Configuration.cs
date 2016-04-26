using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Kintrests.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Kintrests.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kintrests.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Kintrests.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<KintrestUser>(context);
            var userManager = new UserManager<KintrestUser>(userStore);

            var kate = new KintrestUser()
            {
                Email = "kateramsey@live.com",
                Handle = "kateramsey",
                UserName = "kateramsey@live.com"
            };
            userManager.Create(kate, "MyP@ssw0rd!");

            var bruce = new KintrestUser()
            {
                Email = "wills_martin@yahoo.com",
                Handle = "brucewills",
                UserName = "wills_martin@yahoo.com"
            };
            userManager.Create(bruce, "KateIsAwes0m3!");

            var seedUsers = new List<KintrestUser> {kate, bruce};

            context.Users.AddOrUpdate(u=> new {u.UserName}, seedUsers.ToArray());
        }
    }
}
