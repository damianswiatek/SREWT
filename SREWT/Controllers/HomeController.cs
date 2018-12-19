using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SREWT.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("api/home/index")]
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
