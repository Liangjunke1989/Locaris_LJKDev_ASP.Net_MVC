using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters
{
    public class MyAction:ActionFilterAttribute
    {
        //表示行为执行前，需要处理的代码
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("ing<br>");
        }

        //表示行为执行后，需要处理的代码
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            filterContext.HttpContext.Response.Write("ed<br>");
        }

    }
}