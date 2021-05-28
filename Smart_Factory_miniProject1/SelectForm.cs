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

            if (Select_RadioButton1.Checked) selected1 = Select_RadioButton1.Text;
            if (Select_RadioButton2.Checked) selected1 = Select_RadioButton2.Text;
            if (Select_RadioButton3.Checked) selected1 = Select_RadioButton3.Text;
            if (Select_RadioButton5.Checked) selected2 = Select_RadioButton5.Text;
            if (Select_RadioButton6.Checked) selected2 = Select_RadioButton6.Text;
            if (Select_RadioButton7.Checked) selected2 = Select_RadioButton7.Text;
            
            if (num != "")
            {
                
                MessageBox.Show(selected1 + " " + selected2 + " " + selected3);
                this.FormSendEvent($"{selected1}/{selected2}/{selected3}/{num}");
            }
            else
            {
                this.FormSendEvent($"{selected1}/{selected2}/{selected3}/-1");
            }
            this.Close();
        }

        private void Select_TextBox_TextChanged(object sender, EventArgs e)
        {
            label_watermark.Visible = Select_TextBox.Text.Length < 1;
        }
    }
}