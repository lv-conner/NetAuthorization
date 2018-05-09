using NetAuthorization.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace NetAuthorization.Filters
{
    public class CustomerAuthenticationFilter : IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            var identity = new GenericIdentity("Tim", "Customer");
            var roles = DependencyResolver.Current.GetService<IAuthenticationServices>().GetRoles(identity.Name);
            var user = new GenericPrincipal(identity, roles.ToArray());
            filterContext.HttpContext.User = user;
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            //filterContext.Result = new RedirectResult("/Account/Login");
        }
    }
}