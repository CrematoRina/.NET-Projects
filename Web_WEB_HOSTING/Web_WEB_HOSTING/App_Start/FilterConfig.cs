using System.Web;
using System.Web.Mvc;

namespace Web_WEB_HOSTING
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}