
namespace Smart_Factory_miniProject1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(494, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(75, 107);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(91, 91);
            this.guna2CircleProgressBar1.TabIndex = 4;
            this.guna2CircleProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2CircleProgressBar1.Value = 50;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(452, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(238, 155);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(230, 126);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "막대";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(230, 126);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "콘";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 338);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 15);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

