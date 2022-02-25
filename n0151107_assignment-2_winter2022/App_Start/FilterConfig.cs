using System.Web;
using System.Web.Mvc;

namespace n0151107_assignment_2_winter2022
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
