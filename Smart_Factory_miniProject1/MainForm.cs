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
using Oracle.ManagedDataAccess.Client;

namespace Smart_Factory_miniProject1
{
    public partial class MainForm : MetroForm
    {
        OracleConnection conn;
        OracleCommand cmd;

        public MainForm()
        {
            InitializeComponent();
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

            cmd.CommandText = "select VOL from ICE_CREAM where ID=902";
            OracleDataReader odr2 = cmd.ExecuteReader();
            while (odr2.Read())
            {
                int VOL = odr2.GetInt32(0);
                S_Vanilla_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=903";
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

            cmd.CommandText = "select VOL from ICE_CREAM where ID=912";
            OracleDataReader odr5 = cmd.ExecuteReader();
            while (odr5.Read())
            {
                int VOL = odr5.GetInt32(0);
                C_Vanilla_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=913";
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

            cmd.CommandText = "select VOL from ICE_CREAM where ID=932";
            OracleDataReader odr8 = cmd.ExecuteReader();
            while (odr8.Read())
            {
                int VOL = odr8.GetInt32(0);
                B_Vanilla_Product.Value = VOL;
            }

            cmd.CommandText = "select VOL from ICE_CREAM where ID=933";
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
        }


        

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroLabel1.Text = DateTime.Now.ToString();
        }
          
        
    }   
}
