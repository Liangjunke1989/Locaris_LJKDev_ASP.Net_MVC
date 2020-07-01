using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Controllers
{
    public class HelloController : Controller
    {
        // GET: LJK_MVC01/Hello
        [MyAction]
        [MyResult]
        public ActionResult Index()
        {
            Response.Write("行为执行中！！！<br>");
            return View();
        }

      
    }
}