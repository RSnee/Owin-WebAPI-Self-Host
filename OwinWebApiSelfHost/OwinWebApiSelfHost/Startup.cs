﻿
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Unity.WebApi;

namespace OwinWebApiSelfHost
  {
  public class Startup
    {
    private static readonly IUnityContainer _container = UnityHelpers.GetConfiguredContainer();

    // This code configures Web API. The Startup class is specified as a type
    // parameter in the WebApp.Start method.
    public void Configuration(IAppBuilder appBuilder)
      {
      // Configure Web API for self-host. 
      HttpConfiguration config = new HttpConfiguration();

      config.DependencyResolver = new UnityDependencyResolver(
      OwinWebApiSelfHost.UnityHelpers.GetConfiguredContainer());

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );

      appBuilder.UseWebApi(config);
      }
    }
  }
