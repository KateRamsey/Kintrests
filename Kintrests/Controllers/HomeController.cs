using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kintrests.Models;
using Microsoft.AspNet.Identity;

namespace Kintrests.Controllers
{
    [Authorize]
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

            var model2 = db.Kins.Where(x => x.Owner.Id == userId).ToList();

            var model = model2.Select(k => new KinVM(k)).ToList();

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


            var newKin = new Kin
            {
                Body = k.Body,
                ImgURL = k.ImgURL,
                LinkURL = k.LinkURL,
                Owner = db.Users.Find(userId)
            };

            if (newKin.LinkURL == null)
            {
                newKin.LinkURL = newKin.ImgURL;
            }

            db.Kins.Add(newKin);
            db.SaveChanges();

            var kin = new KinVM(newKin);

            return Json(kin, JsonRequestBehavior.AllowGet);
        }

    }
}