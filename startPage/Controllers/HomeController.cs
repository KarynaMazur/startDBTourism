
using startPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace startPage.Controllers
{
    public class HomeController : Controller
    {

        TextContent db = new TextContent();

        public ActionResult Index()
        {
            var about = db.Abouts.SingleOrDefault(a => a.Id == 1);
            about.AboutContent = Parser.WriteAboutContectToPage();
            return View(about);
            //return View("Index",Parser.WriteAboutContectToPage());
        }

        [HttpPost]
        public string Index(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return $"customer {user.Name}, we find and call you)";
        }

            

       // [HttpGet]
        //public ActionResult Buy()
        //{

        //}
        //public ActionResult Index()
        //{
        //    return View();
        //}
    //}

    //public ActionResult Buy()
    //{      
    //    return View();
    //}

    //public ActionResult Contact()
    //{
    //    ViewBag.Message = "Your contact page.";

    //    return View();
    }
}
