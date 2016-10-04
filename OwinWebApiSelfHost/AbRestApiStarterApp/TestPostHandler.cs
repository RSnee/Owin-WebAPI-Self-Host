using AbRestApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbRestApiStarterApp
{
  class TestPostHandler : IPostHandler
  {
    public string Id { get; set; }
    public string ReturnMessage { get; set; }
    public bool ReturnOk { get; set; }

    public TestPostHandler()
    { }

    public PostReturnValue HandlePost(string postValue)
    {
      return new PostReturnValue()
      {
        InputValue = postValue,
        Message = $"Message from PostHandler with Id '{this.Id}': {this.ReturnMessage}",
        Ok = this.ReturnOk
      };
    }
  }
}
