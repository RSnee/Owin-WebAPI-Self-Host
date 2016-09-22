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

        public void Start()
        {
            string baseAddress = "http://localhost:9001/";
            this.Server = WebApp.Start<Startup>(url: baseAddress);
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
