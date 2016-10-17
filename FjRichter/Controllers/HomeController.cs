using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FjRichter.ViewModels;
using FJRichter.Models;

namespace FjRichter.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your application description page.";
            using (EntityContext db = new EntityContext())
            {
                var model = new BlogViewModel
                {
                    Content = db.Contents.FirstOrDefault(c => c.Id == 3),
                    Subjects = db.Subjects.Include(p => p.Posts).ToList()
                };
            return View(model);
            }
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}