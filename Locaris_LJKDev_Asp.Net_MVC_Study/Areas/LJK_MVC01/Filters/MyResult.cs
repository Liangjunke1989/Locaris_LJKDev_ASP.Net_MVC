using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters
{
    public class MyResult:ActionFilterAttribute
    {
        //表示结果执行前，需要处理的代码
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //base.OnResultExecuting(filterContext);
            filterContext.HttpContext.Response.Write("结果执行前<br>");
        }
        //表示结果执行后，需要处理的代码
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            filterContext.HttpContext.Response.Write("结果执行完<br>");
        }
    }
}