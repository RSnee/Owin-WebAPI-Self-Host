using OwinWebApiSelfHost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwinWebApiSelfHostTester
{
    public partial class Form1 : Form
    {

        private RestServer Server { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.Server = new RestServer();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Server.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.Server.Stop();
        }
    }
}
