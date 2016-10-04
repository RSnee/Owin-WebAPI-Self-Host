using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinWebApiSelfHost
  {
  public interface IPostHandler
    {
    PostReturnValue HandlePost(string postValue);
    }
  }
