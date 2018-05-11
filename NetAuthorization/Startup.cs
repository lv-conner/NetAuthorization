using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using NetAuthorization.Middlewares;
using Owin;
using Autofac.Integration.Owin;
using Autofac.Core;
using Autofac;
using NetAuthorization.Services;

[assembly: OwinStartup(typeof(NetAuthorization.Startup))]

namespace NetAuthorization
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //配置Autoface中间件容器。将服务注册到DI容器中，将中间件注册到DI容器中，后续的中间件获取和解析均交由DI容器进行解析。
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<DateTimeOwinMiddleware>();
            builder.RegisterType<AuthenticationServices>().As<IAuthenticationServices>();
            app.UseAutofacMiddleware(builder.Build());
            //app.Use<DateTimeOwinMiddleware>();
            // 有关如何配置应用程序的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
