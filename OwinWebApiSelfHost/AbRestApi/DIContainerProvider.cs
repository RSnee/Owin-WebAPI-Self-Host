using SimpleInjector;
using SimpleInjector.Extensions.ExecutionContextScoping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbRestApi
{
  public static class DIContainerProvider
  {
    public static Container OwinContainer { get; private set; }

    static DIContainerProvider()
    {
      RenewOwinContainer();
    }

    public static void RenewOwinContainer()
    {
      if (OwinContainer != null)
        OwinContainer.Dispose();

      OwinContainer = new Container();
      OwinContainer.Options.DefaultScopedLifestyle = new ExecutionContextScopeLifestyle();
    }
  }
}
