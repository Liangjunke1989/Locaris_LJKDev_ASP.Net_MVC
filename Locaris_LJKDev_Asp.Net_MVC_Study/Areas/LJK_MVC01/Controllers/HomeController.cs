using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Controllers
{
    //[MyAuthorization] //当前控制器下的所有行为，都被应用了这个过滤器
    public class HomeController : MyBaseController
    {
        // GET: LJK_MVC01/Home
       
        [MyException]
        public ActionResult Index()
        {
            //throw new Exception("000");
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        //过滤器的第二种实现方式：重写控制器的方法，这样，会应用于所有的行为
        // protected override void OnAuthorization(AuthorizationContext filterContext)
        //{
        //    filterContext.HttpContext.Response.Write("ljk111");
        //}
    }
}