using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Controllers
{
    public class MyBaseController : Controller
    {
        //01身份验证过滤器
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.HttpContext.Response.Write("ljk111");
        }

        //02行为过滤器
        //表示行为执行前，需要处理的代码
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("ing<br>");
        }

        //表示行为执行后，需要处理的代码
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //base.OnActionExecuted(filterContext);
            filterContext.HttpContext.Response.Write("ed<br>");
        }

        //03结果过滤器
        //表示结果执行前，需要处理的代码
        protected override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            //base.OnResultExecuting(filterContext);
            filterContext.HttpContext.Response.Write("结果执行前<br>");
        }
        //表示结果执行后，需要处理的代码
        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            //base.OnResultExecuted(filterContext);
            filterContext.HttpContext.Response.Write("结果执行完<br>");
        }

        //04异常过滤器
        protected override void OnException(ExceptionContext filterContext)
        {
            //如下代码不可以被删除，不然捕获不到异常
            base.OnException(filterContext);
            //记录日志

            //页面跳转
            filterContext.Result = new RedirectResult("/LJK_MVC01/Error/400.Html");
        }


    }
}