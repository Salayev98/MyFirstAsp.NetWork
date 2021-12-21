using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NetProject.Controllers
{
    public class HomeController:Controller
    {
        //public ContentResult Index(int id)
        //{
        //    var result = new ContentResult();
        //    result.Content = "Salam Anar Salayev" + "Menim Yawim " + id.ToString() + " -dir";
        //    return result;
        //}
        public ActionResult Json()
        {
            var result = new JsonResult(new { name="anar",surname= "salayev"});
            return result;
        }
        public ActionResult Detail(int id, string surname, string name)
        {
            ViewData["Id"] = id;
            ViewData["Surname"] = surname;
            ViewData["Name"] = name;
            ViewBag.Id = id;
            ViewBag.Surname= surname;
            ViewBag.Name = name;
            TempData["Id"] = id;
            TempData["Surname"] = surname;
            TempData["Name"] = name;

            return View();
        }
        public ActionResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "Index";
            return view;
        }
        public ActionResult About()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "About";
            return view;
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
