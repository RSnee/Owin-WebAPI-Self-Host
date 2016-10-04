using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbRestApi
{
  public interface IPostHandler
  {
    PostReturnValue HandlePost(string postValue);
  }
}
