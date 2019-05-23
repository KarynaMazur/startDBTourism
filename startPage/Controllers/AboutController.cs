using startPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace startPage.Controllers
{
    public class AboutController:Controller
    {
        TextContent db = new TextContent();

        public ActionResult AppdateContent(About about)
        {
            var aboutInDb = db.Abouts.Single(a => a.Id == about.Id);
            aboutInDb.AboutContent = Parser.WriteAboutContectToFile(about.AboutContent);
            return RedirectToAction("Index","Home");
        }
        public ActionResult returnForm()
        {
            return View("About");
        }
    }
}