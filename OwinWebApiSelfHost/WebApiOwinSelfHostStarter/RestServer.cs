using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;

namespace WebApiOwinSelfHostStarter
  {
  public class RestServer
    {
    private IDisposable Server { get; set; }

    public bool IsRunning { get { return this.Server != null; } }
    public string BaseAddress1 { get; set; } = $"http://localhost:9090/";
    public string BaseAddress2 { get; set; } = $"http://{Environment.MachineName}:9090/";

    private static RestServer theInstance = new RestServer();

    static RestServer()
      {}

    private RestServer()
      {}

    public static RestServer GetInstance()
      {
      return RestServer.theInstance;
      }

    public bool Start(IPostHandler externalPostHandler)
      {
      if (this.IsRunning)
        return false;

      DIContainerProvider.RenewOwinContainer();
      DIContainerProvider.OwinContainer.Register<IPostHandler>(() => externalPostHandler, (Lifestyle.Scoped));

      StartOptions options = new StartOptions();
      options.Urls.Add(this.BaseAddress1);
      options.Urls.Add(this.BaseAddress2);

      this.Server = WebApp.Start<Startup>(options);
      return true;
      }

    public void Stop()
      {
      if (this.Server != null)
        {
        this.Server.Dispose();
        this.Server = null;
        }
      }

    }
  }
