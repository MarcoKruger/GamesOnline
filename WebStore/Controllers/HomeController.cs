using System;
using System.Web.Mvc;
using Filters.Infrastructure;
using System.Web.Routing;

namespace UrlsAndRoutes.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id = "DefaultId") {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            ViewBag.CustomVariable = id;
            return View();
        }

        public ViewResult MyActionMethod() {
            string myActionUrl = Url.Action("Index", new { id = "MyID" });
            string myRouteUrl = Url.RouteUrl(new { controller = "Home",
                action = "Index" });
            //... do something with URLs...
            return View();
        }

        [CustomAuth(false)]
         public string Index() {
            return "This is the Index action on the Home controller";
        }

    }
}
