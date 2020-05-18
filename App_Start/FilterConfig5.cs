using System.Web;
using System.Web.Mvc;

namespace Food_ordering_system_PROJECT
{
    public class FilterConfig5
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
