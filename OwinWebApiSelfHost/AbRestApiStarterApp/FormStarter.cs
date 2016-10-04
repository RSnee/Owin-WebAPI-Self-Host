using AbRestApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbRestApiStarterApp
{
  public partial class FormStarter : Form
  {
    private RestServer RestServer { get; set; }

    public FormStarter()
    {
      InitializeComponent();
      this.RestServer = RestServer.GetInstance();
      this.cmbBoxOk.SelectedIndex = 0;
      actualizeForm();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      string errorText = string.Empty;
      int port;

      if (int.TryParse(this.txtBoxPort.Text, out port))
      {
        TestPostHandler postHandler = new TestPostHandler()
        {
          Id = this.txtBoxId.Text,
          ReturnMessage = this.txtBoxMessage.Text,
          ReturnOk = this.cmbBoxOk.Text == "true"
        };

        if (!this.RestServer.Start(port, postHandler))
          errorText = "error starting the server";
      }
      else
      {
        errorText = "cannot parse the port";
      }

      actualizeForm(errorText);
    }

    private void actualizeForm()
    {
      actualizeForm(string.Empty);
    }

    private void actualizeForm(string errorText)
    {
      this.btnStart.Enabled = !this.RestServer.IsRunning;
      this.btnStop.Enabled = this.RestServer.IsRunning;
      this.lbStatus.Text = this.RestServer.IsRunning ? $"Server ist running on" : "Server not running";
      this.labelBaseAdress.Text = this.RestServer.IsRunning ? this.RestServer.BaseAddress : errorText;
      this.txtBoxPort.Enabled = !this.RestServer.IsRunning;
      this.txtBoxId.Enabled = !this.RestServer.IsRunning;
      this.cmbBoxOk.Enabled = !this.RestServer.IsRunning;
      this.txtBoxMessage.Enabled = !this.RestServer.IsRunning;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      this.RestServer.Stop();
      actualizeForm();
    }
  }
}
