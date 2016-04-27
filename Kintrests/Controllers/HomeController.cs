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

    }
}