using System.Web;
using System.Web.Mvc;

namespace Assignment2_BryanHughes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
