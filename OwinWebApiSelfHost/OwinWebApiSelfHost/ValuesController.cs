﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinWebApiSelfHost
  {
  public class PostReturnValue
    {
    public string Message { get; set; }
    public string InputValue { get; set; }
    public bool Ok { get; set; }
    }

  public class ValuesController : ApiController
    {
    // GET api/values 
    public IEnumerable<string> Get()
      {
      return new string[] { "value1", "value2" };
      }

    // GET api/values/5 
    public string Get(int id)
      {
      return "value";
      }

    // POST api/values 
    public PostReturnValue Post([FromBody]string value)
      {
      return new PostReturnValue() { InputValue = value, Message = "Hello from Post", Ok = true };
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
