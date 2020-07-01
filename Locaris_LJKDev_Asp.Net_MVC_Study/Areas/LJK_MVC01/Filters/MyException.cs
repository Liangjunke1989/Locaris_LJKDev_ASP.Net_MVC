using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters
{
    public class MyException:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //如下代码不可以被删除，不然捕获不到异常
            base.OnException(filterContext);
            //记录日志

            //页面跳转
            filterContext.Result=new RedirectResult("/LJK_MVC01/Error/400.Html");
        }
    }
}