using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiSelfHost
  {
  public class RestServer
    {
    private IDisposable Server { get; set; }

    public bool IsRunning {  get { return this.Server != null; } }
    public string BaseAddress { get; set; } = "http://localhost:9001/";

    public void Start()
      {
      if (this.Server == null)
        this.Server = WebApp.Start<Startup>(url: this.BaseAddress);
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
