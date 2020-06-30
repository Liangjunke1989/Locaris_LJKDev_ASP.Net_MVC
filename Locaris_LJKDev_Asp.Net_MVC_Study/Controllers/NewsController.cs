using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show(int id,int year,int month,int day)
        {
            ViewBag.Id = id;
            ViewBag.Year = year;
            ViewBag.Month = month;
            ViewBag.Day = day;
            return View();
        }
    }
}