using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kintrests.Models;
using Microsoft.AspNet.Identity;

namespace Kintrests.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllKins()
        {
            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var model = db.Kins.Where(x => x.Owner.Id == userId).Select(n => new KinVM()
            {
                OwnerHandle = n.Owner.Handle,
                Body = n.Body,
                Id = n.Id,
                ImgURL = n.ImgURL,
                LinkURL = n.LinkURL
            }).ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult NewKin(NewKinVM k)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }
            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var newKin = new Kin
            {
                Body = k.Body,
                ImgURL = k.ImgURL,
                LinkURL = k.LinkURL,
                Owner = db.Users.Find(userId)
            };

            db.Kins.Add(newKin);

            return Json(newKin, JsonRequestBehavior.AllowGet);
        }

    }
}