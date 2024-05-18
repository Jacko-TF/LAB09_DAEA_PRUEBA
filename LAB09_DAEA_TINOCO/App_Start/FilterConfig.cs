using System.Web;
using System.Web.Mvc;

namespace LAB09_DAEA_TINOCO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
