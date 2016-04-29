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
            if (context.Users.Any())
            {
                return;
            }
            var userStore = new UserStore<KintrestUser>(context);
            var userManager = new UserManager<KintrestUser>(userStore);

            var kate = new KintrestUser()
            {
                Email = "kateramsey@live.com",
                Handle = "kateramsey",
                UserName = "kateramsey@live.com"
            };
            userManager.Create(kate, "MyP@ssw0rd!");

            kate.Kins.Add(new Kin()
            {
                Owner = kate,
                Body = "I love the turrets in Portal 2",
                ImgURL = "https://img.society6.com/cdn/0014/p/4531933_12374889_lz.jpg",
                LinkURL = "https://img.society6.com/cdn/0014/p/4531933_12374889_lz.jpg",
            });

            kate.Kins.Add(new Kin()
            {
                Owner = kate,
                Body = "Oh Wheatley :)",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/b2/dc/20/b2dc20d029a41b8e3aa0e69e18f12e57.jpg",
                LinkURL = "http://www.thinkwithportals.com/"
            });

            kate.Kins.Add(new Kin()
            {
                Owner = kate,
                Body = "Life Lessons from Cave Johnson",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/e6/e4/24/e6e424039a44edc9f4270bc909d1a3aa.jpg",
                LinkURL = "https://www.etsy.com/listing/73754501/when-life-gives-you-lemons-11x17-poster"
            });

            kate.Kins.Add(new Kin()
            {
                Owner = kate,
                Body = "From the sky to the core",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/5d/17/fd/5d17fd0bd22c8bc20d7e0c32ce91677a.jpg",
                LinkURL = "http://decarabia.soup.io/post/138052126/Image"
            });

            kate.Kins.Add(new Kin()
            {
                Owner = kate,
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/a9/75/2b/a9752b80f4dfec1668117a8c9dba0597.jpg",
                LinkURL = "https://s-media-cache-ak0.pinimg.com/564x/a9/75/2b/a9752b80f4dfec1668117a8c9dba0597.jpg"
            });

            kate.Kins.Add(new Kin()
            {
                Owner = kate,
                ImgURL =
                    "https://s-media-cache-ak0.pinimg.com/originals/87/b0/85/87b085cf7b1cc5f460cba801f6226d54.jpg",
                LinkURL =
                    "https://s-media-cache-ak0.pinimg.com/originals/87/b0/85/87b085cf7b1cc5f460cba801f6226d54.jpg"
            });

            context.Kins.AddRange(kate.Kins);



            var bruce = new KintrestUser()
            {
                Email = "wills_martin@yahoo.com",
                Handle = "brucewills",
                UserName = "wills_martin@yahoo.com"
            };
            userManager.Create(bruce, "KateIsAwes0m3!");


            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/a0/73/ca/a073caef07ae6e42fe3d4b9c0d4d7329.jpg",
                LinkURL = "https://s-media-cache-ak0.pinimg.com/564x/a0/73/ca/a073caef07ae6e42fe3d4b9c0d4d7329.jpg"
            });


            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                Body = "Different types of Fallout players",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/dc/c7/9f/dcc79ffd9df821c79c2942dc370b6d6b.jpg",
                LinkURL = "http://www.dorkly.com/post/74478/10-different-fallout-players"
            });

            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                Body = "I'm thinking road trip!",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/6a/28/e6/6a28e6585816bb31eafd73e43a56a872.jpg",
                LinkURL = "http://fallout.wikia.com/wiki/Fallout:_New_Vegas"
            });

            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                Body = "No Deathclaws, those are bad Deathclaws",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/ec/01/7f/ec017f47c2f9bf06bb393ef5c7d69b8f.jpg",
                LinkURL = "https://s-media-cache-ak0.pinimg.com/564x/ec/01/7f/ec017f47c2f9bf06bb393ef5c7d69b8f.jpg"
            });

            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/3e/d9/3a/3ed93a7d45995fc4caf2270b9b050d40.jpg",
                LinkURL = "https://s-media-cache-ak0.pinimg.com/564x/3e/d9/3a/3ed93a7d45995fc4caf2270b9b050d40.jpg"
            });

            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                Body = "A Fallout poem...",
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/66/f6/ab/66f6ab75b1f1987d45b88bf218f80e43.jpg",
                LinkURL = "https://s-media-cache-ak0.pinimg.com/564x/66/f6/ab/66f6ab75b1f1987d45b88bf218f80e43.jpg"
            });

            bruce.Kins.Add(new Kin()
            {
                Owner = bruce,
                ImgURL = "https://s-media-cache-ak0.pinimg.com/564x/aa/da/23/aada23d8e0b878a4eef053d817ff30fd.jpg",
                LinkURL = "https://www.fallout4.com"
            });
            context.Kins.AddRange(bruce.Kins);

            var seedUsers = new List<KintrestUser> {kate, bruce};


            context.Users.AddOrUpdate(u => new {u.UserName}, seedUsers.ToArray());
        }
    }
}
