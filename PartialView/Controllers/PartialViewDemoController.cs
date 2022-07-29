using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialView.Controllers
{
    public class PartialViewDemoController : Controller
    {
        // GET: PartialViewDemo
        public ViewResult Index()
        {
            return View();
        }

        //partial view
        public PartialViewResult Login()
        {
            return PartialView();
        }
    }
}