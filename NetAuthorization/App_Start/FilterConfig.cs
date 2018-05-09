using NetAuthorization.Filters;
using System.Web;
using System.Web.Mvc;

namespace NetAuthorization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CustomerAuthenticationFilter());
            filters.Add(new CustomerAuthorizationFilter());
            filters.Add(new CustomerHandlerErrorFilter());
        }
    }
}
