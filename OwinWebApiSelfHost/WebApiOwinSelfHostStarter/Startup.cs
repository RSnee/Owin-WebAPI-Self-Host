using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;
using SimpleInjector.Extensions.ExecutionContextScoping;
using SimpleInjector.Integration.WebApi;

namespace WebApiOwinSelfHostStarter
  {
  public class Startup
    {
    // This code configures Web API. The Startup class is specified as a type
    // parameter in the WebApp.Start method.
    public void Configuration(IAppBuilder appBuilder)
      {
      appBuilder.Use(async (context, next) =>
      {
        using (DIContainerProvider.OwinContainer.BeginExecutionContextScope())
          {
          await next();
          }
      });

      // Configure Web API for self-host. 
      HttpConfiguration config = new HttpConfiguration();
      config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(DIContainerProvider.OwinContainer);

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );

      appBuilder.UseWebApi(config);
      }
    }
  }
