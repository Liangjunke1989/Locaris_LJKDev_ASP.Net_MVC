using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters
{
    public class MyAuthorization:AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //如果保留如下代码，则会运行.net Framework定义好的身份验证；如果希望自定义身份验证，则需要删除如下代码！
            //base.OnAuthorization(filterContext);

            //如果希望跳转到另外一个页面，需要使用到Result，而不是使用Response.Redirect(),第二种方案不会让服务器端停止执行！
            //filterContext.Result=new RedirectResult(url:"");

            //获取路由数据：当前上下文匹配到路由规则后，得到的一个对象
           // RouteData filterContextRouteData = filterContext.RouteData;

            //获取上下文
            filterContext.HttpContext.Response.Write("LJK_000");
        }
    }
}