using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Smart_Factory_miniProject1
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel1.Text = DateTime.Now.ToLongDateString()+DateTime.Now.ToLongTimeString();
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
