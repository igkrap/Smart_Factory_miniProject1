using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Smart_Factory_miniProject1
{
    public partial class MainForm : MetroForm
    {
        OracleConnection conn;
        OracleCommand cmd;
        SelectForm form3;
        static Thread t1;
        bool flag = false;
        int amount = 0,performance=0;
        string select1 = "", select2 = "", select3 = "";
        string[,] products = { { "초코바", "초코콘", "초코통아이스크림" },
                                { "딸기바", "딸기콘", "딸기통아이스크림" },
                                { "바닐라바", "바닐라콘", "바닐라통아이스크림" } };
        Image image_step1,image_step2,image_step3,image_step4;
        Guna.UI2.WinForms.Guna2ProgressBar productbar ;
        Guna.UI2.WinForms.Guna2CircleProgressBar flavour;
        Guna.UI2.WinForms.Guna2CircleProgressBar scb;
        Guna.UI2.WinForms.Guna2CircleProgressBar package;
        string product = "";
        
        public MainForm()
        {
            InitializeComponent();
            this.BackColor= Color.FromArgb(15, 20, 42);
            timer1.Start();
            string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=220.69.249.218)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=system;Password=1234;";

            // 오라클 연결
            conn = new OracleConnection(strConn);
            conn.Open();
            // 명령 객체 생성
            cmd = new OracleCommand();
            Oraclesearch();
        }


        void Oraclesearch()
        {
            //생산량 현황
            cmd.Connection = conn;
            cmd.CommandText = "select VOL from ICE_CREAM where ID=901";
            OracleDataReader odr1 = cmd.ExecuteReader();
            while (odr1.Read())
            {
                int VOL = odr1.GetInt32(0);
                S_Choco_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=903";
            OracleDataReader odr2 = cmd.ExecuteReader();
            while (odr2.Read())
            {
                int VOL = odr2.GetInt32(0);
                S_Vanilla_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=902";
            OracleDataReader odr3 = cmd.ExecuteReader();
            while (odr3.Read())
            {
                int VOL = odr3.GetInt32(0);
                S_Straw_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=911";
            OracleDataReader odr4 = cmd.ExecuteReader();
            while (odr4.Read())
            {
                int VOL = odr4.GetInt32(0);
                C_Choco_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=913";
            OracleDataReader odr5 = cmd.ExecuteReader();
            while (odr5.Read())
            {
                int VOL = odr5.GetInt32(0);
                C_Vanilla_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=912";
            OracleDataReader odr6 = cmd.ExecuteReader();
            while (odr6.Read())
            {
                int VOL = odr6.GetInt32(0);
                C_Straw_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=931";
            OracleDataReader odr7 = cmd.ExecuteReader();
            while (odr7.Read())
            {
                int VOL = odr7.GetInt32(0);
                B_Choco_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=933";
            OracleDataReader odr8 = cmd.ExecuteReader();
            while (odr8.Read())
            {
                int VOL = odr8.GetInt32(0);
                B_Vanilla_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=932";
            OracleDataReader odr9 = cmd.ExecuteReader();
            while (odr9.Read())
            {
                int VOL = odr9.GetInt32(0);
                B_Straw_Product.Value = VOL;
            }

            //재고현황
            cmd.CommandText = "select VOL from INGREDIENT where ID=1101";
            OracleDataReader rdr1 = cmd.ExecuteReader();
            while (rdr1.Read())
            {
                int VOL = rdr1.GetInt32(0);
                Choco_Soft.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID=1102";
            OracleDataReader rdr2 = cmd.ExecuteReader();
            while (rdr2.Read())
            {
                int VOL = rdr2.GetInt32(0);
                Straw_Soft.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID=1103";
            OracleDataReader rdr3 = cmd.ExecuteReader();
            while (rdr3.Read())
            {
                int VOL = rdr3.GetInt32(0);
                Vanilla_Soft.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID=1001";
            OracleDataReader rdr4 = cmd.ExecuteReader();
            while (rdr4.Read())
            {
                int VOL = rdr4.GetInt32(0);
                Stick.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID=1002";
            OracleDataReader rdr5 = cmd.ExecuteReader();
            while (rdr5.Read())
            {
                int VOL = rdr5.GetInt32(0);
                Cone.Value = VOL;
            }

            cmd.CommandText = "select VOL from INGREDIENT where ID=1003";
            OracleDataReader rdr6 = cmd.ExecuteReader();
            while (rdr6.Read())
            {
                int VOL = rdr6.GetInt32(0);
                Barrel.Value = VOL;
            }
            cmd.CommandText = "select VOL from INGREDIENT where ID=1201";
            OracleDataReader rdr7 = cmd.ExecuteReader();
            while (rdr7.Read())
            {
                int VOL = rdr7.GetInt32(0);
                Vinyl.Value = VOL;
            }
            cmd.CommandText = "select VOL from INGREDIENT where ID=1202";
            OracleDataReader rdr8 = cmd.ExecuteReader();
            while (rdr8.Read())
            {
                int VOL = rdr8.GetInt32(0);
                Plastic.Value = VOL;
            }
            sumProduct();
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)//생산시작 버튼 클릭 이벤트
        {
            
            if (select1 != "" && select2 != "" && select3 != ""&&flavour.Value>0&&scb.Value>0&&package.Value>0&&!flag) { 
                    
                flag = true;
                guna2Button2.Enabled = true;
                guna2Button2.Visible = true;
                guna2CircleProgressBar2.Maximum = (amount > 0) ? amount : new int[]{ flavour.Value,scb.Value,package.Value}.Min();
                metroLabel1.Text = "목표량 : " + guna2CircleProgressBar2.Maximum;
                t1 = new Thread(new ThreadStart(Run));
                t1.Start();
                guna2Button1.Enabled = false;
                guna2Button1.Visible = false;
                btnADDForm.Enabled = false;
                btnADDForm.Visible = false;
                btnSelectForm.Enabled = false;
                btnSelectForm.Visible = false;


            }
        }
        private void useIngredient(Guna.UI2.WinForms.Guna2CircleProgressBar pb, int id)
        {
            // SQL문 지정 및 INSERT 실행
            // 검은펜 심
            //update ingredient set vol = 0;
            pb.Value -= 1;
            cmd.CommandText = $"update ingredient set vol = {pb.Value} where ID = {id}";
            cmd.ExecuteNonQuery();
        }
        private void addProduct(Guna.UI2.WinForms.Guna2ProgressBar pb, int id)
        {
            // SQL문 지정 및 INSERT 실행
            // 검은펜 심
            //update ingredient set vol = 0;
            pb.Value += 1;
            cmd.CommandText = $"update ICE_CREAM set vol = {pb.Value} where ID = {id}";
            cmd.ExecuteNonQuery();
            sumProduct();
            ++performance;
            guna2CircleProgressBar2.Value = performance;
        }
        private void sumProduct() 
        {
            S_Total_Product.Value = S_Choco_Product.Value + S_Straw_Product.Value + S_Vanilla_Product.Value;
            C_Total_Product.Value = C_Choco_Product.Value + C_Straw_Product.Value + C_Vanilla_Product.Value;
            B_Total_Product.Value = B_Choco_Product.Value + B_Straw_Product.Value + B_Vanilla_Product.Value;
        }
        void Run()
        {

            producing.Text = product + " 생산 중...";
            Step1();
        }
        void Step1() // 막대,콘,통 투입
        {
            if (flag == true)
            {
                guna2CircleProgressBar1.Value = 0;
                int id = 0;
                switch (scb.Name)
                {
                    case "Stick": id = 1001; break;
                    case "Cone": id = 1002;  break;
                    case "Barrel": id = 1003;  break;
                }
                useIngredient(scb, id);
          
                pictureBox1.Image = image_step1;
                producing.Text = select2 + "를 넣고 있습니다...";
                Application.DoEvents();
                
                for (int i = 0; i < 25; i++)
                {
                    guna2CircleProgressBar1.Value += 1;
                    Thread.Sleep(100);
                }
                
                
                

                Step2();
            }
          
        }
        void Step2() // 원액 투입
        {
            if(flag==true){ 
            int id = 0;
            switch (flavour.Name)
            {
                case "Choco_Soft": id = 1101; break;
                case "Straw_Soft": id = 1102; break;
                case "Vanilla_Soft": id = 1103; break;
            }
            useIngredient(flavour, id);
            
            pictureBox1.Image = image_step2;
            producing.Text = select1 + "소프트크림을 넣고 있습니다...";
                Application.DoEvents();
                
                for (int i = 0; i < 25; i++)
                {
                    guna2CircleProgressBar1.Value += 1;
                    Thread.Sleep(100);
                }




                //Oraclesearch();
                Step3();
        }
            
        }
        void Step3() // 동결작업
        {
            if (flag == true)
            {
                
                pictureBox1.Image = image_step3;
                producing.Text = select1 + "크림을 얼리고 있습니다.";
                Application.DoEvents();
                
                for (int i = 0; i < 25; i++)
                {
                    guna2CircleProgressBar1.Value += 1;
                    Thread.Sleep(100);
                }



                //Oraclesearch();
                Step4();
            }

        
        }
            void Step4() // 포장
        {
            if (flag == true) {
                int id = 0;
                switch (package.Name)
                {
                    case "Vinyl": id = 1201; break;
                    case "Plastic": id = 1202; break;
                }
                useIngredient(package, id);
                
                pictureBox1.Image = image_step4;
                producing.Text = product + " 포장완료";
                
                Application.DoEvents();
                for (int i = 0; i < 25; i++)
                {
                    guna2CircleProgressBar1.Value += 1;
                    Thread.Sleep(100);
                }

                //Oraclesearch();

                switch (productbar.Name)
            {
                case "S_Choco_Product":id=901; break;
                case "C_Choco_Product": id = 911; break;
                case "B_Choco_Product": id = 931; break;
                case "S_Straw_Product": id = 902; break;
                case "C_Straw_Product": id = 912; break;
                case "B_Straw_Product": id = 932; break;
                case "S_Vanilla_Product": id = 903; break;
                case "C_Vanilla_Product": id = 913; break;
                case "B_Vanilla_Product": id = 933; break;
            }
            addProduct(productbar, id);

                if (flavour.Value > 0 && scb.Value > 0 && package.Value > 0 && guna2CircleProgressBar2.Value < guna2CircleProgressBar2.Maximum)
                    Step1();
                else
                {
                    flag = false;
                    pictureBox1.Image = null;
                    guna2CircleProgressBar1.Value = 0;
                    guna2CircleProgressBar2.Value = 0;
                    producing.Text = "";
                    metroLabel1.Text = "";
                    Application.DoEvents();
                    performance = 0;
                    guna2Button1.Enabled = true;
                    guna2Button1.Visible = true;
                    btnADDForm.Enabled = true;
                    btnADDForm.Visible = true;
                    btnSelectForm.Enabled = true;
                    btnSelectForm.Visible = true;
                    guna2Button2.Enabled = false;
                    guna2Button2.Visible = false;
                }
            }
           
        }
        void productStop() {
            t1.Abort();
            flag = false;
            producing.Text = product + " 생산을 종료합니다.";
            Application.DoEvents();
            Thread.Sleep(500);
            pictureBox1.Image = null;
            guna2CircleProgressBar1.Value = 0;
            guna2CircleProgressBar2.Value = 0;
            producing.Text = "";
            metroLabel1.Text = "";
            Application.DoEvents();
            performance = 0;
            guna2Button1.Enabled = true;
            guna2Button1.Visible = true;
            btnADDForm.Enabled = true;
            btnADDForm.Visible = true;
            btnSelectForm.Enabled = true;
            btnSelectForm.Visible = true;
            guna2Button2.Enabled = false;
            guna2Button2.Visible = false;

        }
        private void guna2GroupBox2_Click(object sender, EventArgs e)// 재료 그룹박스 클릭 이벤트
        {
            Choco_Label.Text = Choco_Soft.Value.ToString() + "/" + Choco_Soft.Maximum.ToString();
            Straw_Label.Text = Straw_Soft.Value.ToString() + "/" + Straw_Soft.Maximum.ToString();
            Vanilla_Label.Text = Vanilla_Soft.Value.ToString() + "/" + Vanilla_Soft.Maximum.ToString();
            Stick_Label.Text = Stick.Value.ToString() + "/" + Stick.Maximum.ToString();
            Cone_Label.Text = Cone.Value.ToString() + "/" + Cone.Maximum.ToString();
            Barrel_Label.Text = Barrel.Value.ToString() + "/" + Barrel.Maximum.ToString();
            Vinyl_Label.Text = Vinyl.Value.ToString() + "/" + Vinyl.Maximum.ToString();
            Plastic_Label.Text = Plastic.Value.ToString() + "/" + Plastic.Maximum.ToString();
            Choco_Soft.ShowPercentage = !Choco_Soft.ShowPercentage;
            Straw_Soft.ShowPercentage = !Straw_Soft.ShowPercentage;
            Vanilla_Soft.ShowPercentage = !Vanilla_Soft.ShowPercentage;
            Stick.ShowPercentage = !Stick.ShowPercentage;
            Cone.ShowPercentage = !Cone.ShowPercentage;
            Barrel.ShowPercentage = !Barrel.ShowPercentage;
            Vinyl.ShowPercentage = !Vinyl.ShowPercentage;
            Plastic.ShowPercentage = !Plastic.ShowPercentage;
            Choco_Label.Visible = !Choco_Label.Visible;
            Straw_Label.Visible = !Straw_Label.Visible;
            Vanilla_Label.Visible = !Vanilla_Label.Visible;
            Stick_Label.Visible = !Stick_Label.Visible;
            Cone_Label.Visible = !Cone_Label.Visible;
            Barrel_Label.Visible = !Barrel_Label.Visible;
            Vinyl_Label.Visible = !Vinyl_Label.Visible;
            Plastic_Label.Visible = !Plastic_Label.Visible;
        }

        private void btnADDForm_Click(object sender, EventArgs e) // 재료 추가 버튼 클릭 이벤트
        {
            if (!flag)
            {
                AddForm form2 = new AddForm(cmd);
                form2.ShowDialog();
                Oraclesearch();
                Choco_Label.Text = Choco_Soft.Value.ToString() + "/" + Choco_Soft.Maximum.ToString();
                Straw_Label.Text = Straw_Soft.Value.ToString() + "/" + Straw_Soft.Maximum.ToString();
                Vanilla_Label.Text = Vanilla_Soft.Value.ToString() + "/" + Vanilla_Soft.Maximum.ToString();
                Stick_Label.Text = Stick.Value.ToString() + "/" + Stick.Maximum.ToString();
                Cone_Label.Text = Cone.Value.ToString() + "/" + Cone.Maximum.ToString();
                Barrel_Label.Text = Barrel.Value.ToString() + "/" + Barrel.Maximum.ToString();
                Vinyl_Label.Text = Vinyl.Value.ToString() + "/" + Vinyl.Maximum.ToString();
                Plastic_Label.Text = Plastic.Value.ToString() + "/" + Plastic.Maximum.ToString();
            }
        }

        private void metroTabPage1_Click(object sender, EventArgs e) // 생산량 탭 클릭 이벤트
        {
            GraphForm form4 = new GraphForm(new string[] { "초코바",
                "딸기바", "바닐라바",
                "초코콘", "딸기콘", "바닐라콘",
                "초코통아이스크림", "딸기통아이스크림", "바닐라통아이스크림"
            }, new int[] { S_Choco_Product.Value, 
                S_Straw_Product.Value, S_Vanilla_Product.Value,
                C_Choco_Product.Value, C_Straw_Product.Value, C_Vanilla_Product.Value,
                B_Choco_Product.Value, B_Straw_Product.Value, B_Vanilla_Product.Value });
            form4.Show();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)// 생산량 탭 클릭 이벤트
        
            {
            GraphForm form4 = new GraphForm(new string[] { "초코바",
                "딸기바", "바닐라바",
                "초코콘", "딸기콘", "바닐라콘",
                "초코통아이스크림", "딸기통아이스크림", "바닐라통아이스크림"
            }, new int[] { S_Choco_Product.Value,
                S_Straw_Product.Value, S_Vanilla_Product.Value,
                C_Choco_Product.Value, C_Straw_Product.Value, C_Vanilla_Product.Value,
                B_Choco_Product.Value, B_Straw_Product.Value, B_Vanilla_Product.Value });
            form4.Show();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)// 생산량 탭 클릭 이벤트
        
        {
            GraphForm form4 = new GraphForm(new string[] { "초코바",
                "딸기바", "바닐라바",
                "초코콘", "딸기콘", "바닐라콘",
                "초코통아이스크림", "딸기통아이스크림", "바닐라통아이스크림"
            }, new int[] { S_Choco_Product.Value,
                S_Straw_Product.Value, S_Vanilla_Product.Value,
                C_Choco_Product.Value, C_Straw_Product.Value, C_Vanilla_Product.Value,
                B_Choco_Product.Value, B_Straw_Product.Value, B_Vanilla_Product.Value });
            form4.Show();
        }

       

        private void guna2Button1_MouseHover(object sender, EventArgs e) // 생산버튼에 마우스 올렸을때,
        {
            
            if (select1 == "" && select2 == "" && select3 == "") { metroToolTip1.SetToolTip(guna2Button1, "재료가 선택되지 않았습니다. 재료 선택 버튼을 눌러 재료를 선택해주세요."); }
            else if (flavour.Value <= 0) {  metroToolTip1.SetToolTip(guna2Button1, flavour.Name + "(이)가 부족합니다. 재료 추가 버튼을 눌러 재료를 추가해주세요."); }
            else if (scb.Value <= 0) {  metroToolTip1.SetToolTip(guna2Button1, scb.Name + "(이)가 부족합니다. 재료 추가 버튼을 눌러 재료를 추가해주세요."); }
            else if (package.Value <= 0) {  metroToolTip1.SetToolTip(guna2Button1, package.Name + "(이)가 부족합니다. 재료 추가 버튼을 눌러 재료를 추가해주세요."); }
            else if (flag){  metroToolTip1.SetToolTip(guna2Button1, "이미 생산하고 있습니다");}
            else metroToolTip1.SetToolTip(guna2Button1, "생산 가능합니다.");


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag ) { t1.Abort(); flag = false; }
            conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e) //생산종료 버튼 클릭 이벤트
        {
            if (flag)
            {
                
                producing.Text = product + " 생산을 종료합니다.";
                productStop();

                
            }
            

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void S_Vanilla_Product_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void B_Choco_Product_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectForm_Click(object sender, EventArgs e)// 재료선택 버튼 클릭 이벤트
        {
            if (!flag)
            {
                form3 = new SelectForm();
                form3.FormSendEvent += new SelectForm.FormSendDataHandler(DieaseUpdateEventMethod);
                form3.Show();
            }
            //

        }
        private void DieaseUpdateEventMethod(object sender)
        {
            string[] arr = ((string)sender).Split('/');
            select1 = arr[0];
            select2 = arr[1];
            //select3 = arr[2];
            amount = int.Parse(arr[3]);
            

            form3.Close();
            int i = 0, j = 0;
            switch (select1)
            {
                case "초코": i = 0; flavour = Choco_Soft;  break;
                case "딸기": i = 1; flavour = Straw_Soft; break;
                case "바닐라": i = 2; flavour = Vanilla_Soft; break;
            }
            switch (select2)
            {
                case "막대": j = 0; scb = Stick; select3 = "비닐";package = Vinyl;  break;
                case "콘": j = 1; scb = Cone; select3 = "플라스틱"; package = Plastic; break;
                case "통": j = 2; scb = Barrel; select3 = "플라스틱"; package = Plastic; break;
            }
            
            product = products[i, j];
            producing.Text = product+" 선택";
            if (i == 0 && j == 0) { productbar = S_Choco_Product; image_step1 = Properties.Resources.나무막대_시작; 
                image_step2 = Properties.Resources.초코_나무막대_원액; image_step3 = Properties.Resources.나무막대_동결; image_step4 = Properties.Resources.초코_나무막대_완성;
            }
            else if (i == 0 && j == 1) { productbar = C_Choco_Product; image_step1 = Properties.Resources.콘_시작;
                image_step2 = Properties.Resources.초코_콘_원액; image_step3 = Properties.Resources.콘_동결; image_step4 = Properties.Resources.초코_콘_완성;
            }
            else if (i == 0 && j == 2) { productbar = B_Choco_Product; image_step1 = Properties.Resources.통_시작;
                image_step2 = Properties.Resources.초코_통_원액; image_step3 = Properties.Resources.통_동결; image_step4 = Properties.Resources.초코_통_완성;
            }
            else if (i == 1 && j == 0) { productbar = S_Straw_Product; image_step1 = Properties.Resources.나무막대_시작;
                image_step2 = Properties.Resources.딸기_나무막대_원액; image_step3 = Properties.Resources.나무막대_동결; image_step4 = Properties.Resources.딸기_나무막대_완성;
            }
            else if (i == 1 && j == 1) { productbar = C_Straw_Product; image_step1 = Properties.Resources.콘_시작;
                image_step2 = Properties.Resources.딸기_콘_원액; image_step3 = Properties.Resources.콘_동결; image_step4 = Properties.Resources.딸기_콘_완성;
            }
            else if (i == 1 && j == 2) { productbar = B_Straw_Product; image_step1 = Properties.Resources.통_시작;
                image_step2 = Properties.Resources.딸기_통_원액; image_step3 = Properties.Resources.통_동결; image_step4 = Properties.Resources.딸기_통_완성;
            }
            else if (i == 2 && j == 0) { productbar = S_Vanilla_Product; image_step1 = Properties.Resources.나무막대_시작;
                image_step2 = Properties.Resources.바닐라_나무막대_원액; image_step3 = Properties.Resources.나무막대_동결; image_step4 = Properties.Resources.바닐라_나무막대_완성;
            }
            else if (i == 2 && j == 1) { productbar = C_Vanilla_Product; image_step1 = Properties.Resources.콘_시작;
                image_step2 = Properties.Resources.바닐라_콘_원액; image_step3 = Properties.Resources.콘_동결; image_step4 = Properties.Resources.바닐라_콘_완성;
            }
            else if (i == 2 && j == 2) { productbar = B_Vanilla_Product; image_step1 = Properties.Resources.통_시작;
                image_step2 = Properties.Resources.바닐라_통_원액; image_step3 = Properties.Resources.통_동결; image_step4 = Properties.Resources.바닐라_통_완성;
            }
            //flag = false;
            //Run();
        }
    }   
}
