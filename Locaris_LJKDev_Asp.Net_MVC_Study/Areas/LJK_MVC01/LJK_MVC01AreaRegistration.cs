using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study.Areas.LJK_MVC01
{
    public class LJK_MVC01AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LJK_MVC01";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LJK_MVC01_default",
                "LJK_MVC01/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}