using System.Web;
using System.Web.Mvc;
using Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01.Filters;

namespace Locaris_LJKDev_Asp.Net_MVC_Study
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        { 
            //系统默认的异常处理过滤器，如果使用自定义异常处理，要将如下代码删除！！
            // filters.Add(new HandleErrorAttribute());
            filters.Add(new MyException());



           //在全局中注册过滤器，则所有控制器的所有行为，都会执行这个过滤器
           //filters.Add(new MyAuthorization());
        }
    }
}
