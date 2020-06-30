using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Locaris_LJKDev_Asp.Net_MVC_Study
{
    public class RouteConfig
    { 
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //自定义路由规则的要求：小范围写在前，大范围写在后
            
            //2020-06-30
            routes.MapRoute(
                name:"NewsShow",
                url:"{year}-{month}-{day}-{id}",
                defaults:new
                {
                    Controller="News",
                    Action="Show"
                },
                constraints:new      //约束
                {
                    year="^\\d{4}$",//正则表达式
                    month= "^\\d{1,2}$",
                    day="^\\d{1,2}$"
                });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Person", action = "Add", id = 15 }
            );
        }
    }
}
