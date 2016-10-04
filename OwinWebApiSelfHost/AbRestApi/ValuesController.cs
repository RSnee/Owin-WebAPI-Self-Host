using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AbRestApi
{
  public class ValuesController : ApiController
  {
    private IPostHandler PostHandler { get; set; }

    public ValuesController(IPostHandler postHandler)
    {
      this.PostHandler = postHandler;
    }

    // GET api/values 
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5 
    public string Get(int id)
    {
      return $"value {id}";
    }

    // POST api/values 
    public PostReturnValue Post([FromBody]string value)
    {
      return this.PostHandler.HandlePost(value);
    }

    // PUT api/values/5 
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5 
    public void Delete(int id)
    {
    }
  }
}
