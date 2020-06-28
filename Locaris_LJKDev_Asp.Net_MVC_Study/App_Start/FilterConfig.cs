using System.Web;
using System.Web.Mvc;

namespace Locaris_LJKDev_Asp.Net_MVC_Study
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
