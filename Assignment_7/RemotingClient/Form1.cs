using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RemotingServer;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;

namespace RemotingClient
{
    public partial class Form1 : Form
    {
        Service remoteobj = new Service();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remoteobj = (Service)Activator.GetObject(typeof(Service), 
                "tcp://localhost:8089/OurFirstRemoteService");
            int n1 = Int32.Parse(textnum1.Text);
            int n2 = Int32.Parse(textnum2.Text);
            textresult.Text = (remoteobj.HighestNumber(n1, n2)).ToString();

        }
    }
}
