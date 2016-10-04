using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwinWebApiSelfHost;

namespace OwinWebApiSelfHostTester
  {
  class MsgBoxPostHandler : IPostHandler
    {
    public PostReturnValue HandlePost(string postValue)
      {
      DialogResult res = MessageBox.Show($"Value from Post {postValue}", "PostHandlingRequired", MessageBoxButtons.OKCancel);
      return new PostReturnValue() { InputValue = postValue, Message = "Hello from MsgBoxPostHandler!", Ok = res == DialogResult.OK };
      }
    }
  }
