using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ABC_Portal.Controllers
{
    public class HomeController : Controller
    {
        Models.ABCUser LoggedInUser = new Models.ABCUser();



        public ActionResult Index()
        {
            return View();
        }

      



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.ABCUser user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(Request.Form["UserName"], Request.Form["Password"]))
                {
                   
                    FormsAuthentication.SetAuthCookie(user.UserName, user.RememberMe);
                    LoggedInUser = user;

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                   
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }



    }
}