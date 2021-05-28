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
    public partial class SelectForm : MetroForm
    {
        public delegate void FormSendDataHandler(string sendstring);
        public event FormSendDataHandler FormSendEvent;
        private string selected1 = "";
        private string selected2 = "";
        private string selected3 = "";
        private string num = "";
        public SelectForm()
        {
            InitializeComponent();
        }

        private void Select_Button_Click(object sender, EventArgs e)
        {
            num = Select_TextBox.Text;
            if (num != "")
            {
                this.FormSendEvent($"{selected1}/{selected2}/{selected3}/{num}");
            }
            else
            {
                this.FormSendEvent($"{selected1}/{selected2}/{selected3}/-1");
            }
            this.Close();
        }

        private void Select_RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selected1 = Select_RadioButton1.Text;
        }

        private void Select_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selected1 = Select_RadioButton2.Text;
        }

        private void Select_RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selected1 = Select_RadioButton3.Text;
        }

        private void Select_RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            selected2 = Select_RadioButton5.Text;
        }

        private void Select_RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            selected2 = Select_RadioButton6.Text;
        }

        private void Select_RadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            selected2 = Select_RadioButton7.Text;
        }

        private void Select_RadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            selected3 = Select_RadioButton8.Text;
        }

        private void Select_RadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            selected3 = Select_RadioButton9.Text;
        }
    }
}