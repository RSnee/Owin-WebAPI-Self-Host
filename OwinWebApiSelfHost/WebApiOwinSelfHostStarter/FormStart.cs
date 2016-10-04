using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApiOwinSelfHostStarter
  {
  public partial class FormStart : Form
    {
    private RestServer Server { get; set; }
    private RestServer Server2 { get; set; }

    public FormStart()
      {
      InitializeComponent();
      this.Server = RestServer.GetInstance();

      this.labelBase1.Text = $"{this.Server.BaseAddress1}";
      this.labelBase2.Text = $"{this.Server.BaseAddress2}";

      actualizeForm();
      }

    private void btnStart_Click(object sender, EventArgs e)
      {
      this.Server.Start(new PostHandlerSample() { Id = Guid.NewGuid().ToString() });
      actualizeForm();
      }

    private void actualizeForm()
      {
      this.btnStart.Enabled = !this.Server.IsRunning;
      this.btnStop.Enabled = this.Server.IsRunning;
      this.lbStatus.Text = this.Server.IsRunning ? $"Server ist running on" : "Server not running";
      this.labelBase1.Visible = this.Server.IsRunning;
      this.labelBase2.Visible = this.Server.IsRunning;
      }

    private void btnStop_Click(object sender, EventArgs e)
      {
      this.Server.Stop();
      actualizeForm();
      }

    private void button1_Click(object sender, EventArgs e)
      {
      this.Server2 = RestServer.GetInstance();
      this.Server2.Start(new PostHandlerSample() { Id = "external 2" });
      }
    }
  }
