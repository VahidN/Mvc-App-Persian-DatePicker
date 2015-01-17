using System;
using System.Web.Mvc;
using MvcAppPersianDatePicker.Models;

namespace MvcAppPersianDatePicker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var model = new Post
            {
                AddDate = DateTime.Now.AddDays(-1), Title = "تست",
                NestedProperty = new OtherInfo { SaveDate = DateTime.Now.AddDays(-2) }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Post post)
        {
            if (ModelState.IsValid)
            {
                // todo: save data
                return RedirectToAction("Index");
            }

            return View(post);
        }

        public ActionResult ShowPopup()
        {
            var model = new Post { AddDate = DateTime.Now.AddDays(-1), Title = "تست" };
            return PartialView("_RemotePopup", model);
        }
    }
}