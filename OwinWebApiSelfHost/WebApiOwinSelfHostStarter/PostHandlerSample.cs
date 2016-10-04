using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiOwinSelfHostStarter
  {
  public class PostHandlerSample : IPostHandler
    {
    public string Id { get; set; }

    public PostReturnValue HandlePost(string postValue)
      {
      // System.Threading.Thread.Sleep(5000);
      return new PostReturnValue() { InputValue = postValue, Message = $"Hello from PostHandler with Id '{this.Id}'", Ok = true };
      }
    }
  }
