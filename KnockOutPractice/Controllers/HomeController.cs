using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockOutPractice.Controllers
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IList<Friend> Friends { get; set; }
    }

    public class Friend
    {
        public string Name { get; set; }
        public bool isOnTwitter { get; set; }
        public string TwitterName { get; set; }
    }

    public class HomeController : Controller
    {

        public ActionResult Save(Person person)
        {
            var message = string.Format("Saved {0} {1}", person.FirstName, person.LastName);
            return Json(new { message });
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult ArrayWithIndex()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult SavingArrays()
        {
            return View();
        }

        public ActionResult SaveFriends(IList<Friend> friends)
        {
            var message = string.Format("Saved {0} people", friends.Count);
            return Json(new { message });
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ClickCounter()
        {
            return View();
        }
    }
}
