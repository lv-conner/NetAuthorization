using Microsoft.Owin;
using NetAuthorization.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Web;

namespace NetAuthorization.Middlewares
{
    public class DateTimeOwinMiddleware : OwinMiddleware
    {
        private readonly IAuthenticationServices _authenticationServices;
        public DateTimeOwinMiddleware(OwinMiddleware next,IAuthenticationServices authenticationServices) :base(next)
        {
            _authenticationServices = authenticationServices;
        }
        public async override Task Invoke(IOwinContext context)
        {

            context.Request.User = new GenericPrincipal(new GenericIdentity("tim", "Owin"), _authenticationServices.GetRoles("tim").ToArray());
            if(context.Request.Path== new PathString("/DateTime"))
            {
                await context.Response.WriteAsync(DateTime.Now.ToShortTimeString());
                return;
            }
            await Next.Invoke(context);
        }
    }
}