using Microsoft.Owin.Hosting;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbRestApi
{
  public class RestServer
  {
    private static RestServer theInstance = new RestServer();

    private IDisposable ServerAsp { get; set; }

    public int Port { get; private set; } = 9001;
    public string BaseAddress { get { return $"http://{Environment.MachineName}:{this.Port.ToString()}/"; } }
    public bool IsRunning { get { return this.ServerAsp != null; } }

    static RestServer()
    { }

    private RestServer()
    { }

    public static RestServer GetInstance()
    {
      return RestServer.theInstance;
    }

    public bool Start(int port, IPostHandler externalPostHandler)
    {
      if (this.IsRunning)
        return false;

      this.Port = port;
      return Start(externalPostHandler);
    }

    public bool Start(IPostHandler externalPostHandler)
    {
      if (this.IsRunning)
        return false;

      // Prepare the DI-Container to inject the externalPostHandler-Instance into the Controller
      DIContainerProvider.RenewOwinContainer();
      DIContainerProvider.OwinContainer.Register<IPostHandler>(() => externalPostHandler, (Lifestyle.Scoped));

      // Start the ASP.NET WebApi
      StartOptions options = new StartOptions();
      options.Urls.Add(this.BaseAddress);
      this.ServerAsp = WebApp.Start<Startup>(options);

      return true;
    }

    public void Stop()
    {
      if (this.ServerAsp != null)
      {
        this.ServerAsp.Dispose();
        this.ServerAsp = null;
      }
    }

  }
}
