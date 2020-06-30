using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Controllers
{
    public class LJK_HomeController : Controller
    {
        // GET: LJK_Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcAdd(int calc1,int calc2)     //键的名字要求一致，不然无法自动装配
        {
            int sum = calc1 + calc2;
            return Content(sum.ToString());
        }
        public ActionResult CalcAdd01(int calc1, int calc2)     //键的名字要求一致，不然无法自动装配
        {
            int sum = calc1 + calc2;
            var temp = new
            {
                Sum = sum
            };
            return Json(temp,JsonRequestBehavior.AllowGet);
        }
    }
}