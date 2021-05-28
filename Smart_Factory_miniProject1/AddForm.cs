using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Guna.UI2.WinForms;

namespace Smart_Factory_miniProject1
{
    public partial class AddForm : MetroForm
    {

        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
            "(HOST=220.69.249.218)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));" +
            "User Id=system;Password=1234;";

        OracleCommand cmd;

        List<product> list = new List<product>();
        List<Guna2TextBox> txt = new List<Guna2TextBox>();
        public AddForm()
        {
            InitializeComponent();
            OracleConnection conn = new OracleConnection(strConn);
            conn.Open();
            // 명령 객체 생성
            cmd = new OracleCommand();
            cmd.Connection = conn;
        }
        public AddForm(OracleCommand cmd)
        {
            InitializeComponent();
            this.cmd = cmd;
        }
        private void save01_Click(object sender, EventArgs e)
        {
            string[] text_names =
            {
                "Ty_tbx1", "Ty_tbx2" , "Ty_tbx3", "Fv_Tbx1", "Fv_Tbx2",
                "Fv_Tbx3", "Vy_tbx1", "Vy_tbx2"
            };

            foreach (var item in text_names)
            {
                Control[] ccc = this.Controls.Find(item, true);
                txt.Add((Guna2TextBox)ccc[0]);
            }

            cmd.CommandText = "select * from ingredient where RowNum < 9 order by id";

            // 결과 리더 객체를 리턴
            OracleDataReader rdr = cmd.ExecuteReader();
            // 레코드 계속 가져와서 루핑
            while (rdr.Read())
            {
                string ID = rdr["ID"].ToString();
                string NAME = rdr["NAME"].ToString();
                string VOL = rdr["VOL"].ToString();

                list.Add(new product(ID, NAME, VOL));
            }

            for (int z = 0; z < list.Count; z++)
            {
                //list = 기존에 있는 값, txt = 추가할 값
                // list[z].VOL, txt[z].Text 문자열임
                int total = int.Parse(list[z].VOL) + int.Parse(txt[z].Text);
                if (total > 100)
                {
                    MessageBox.Show($"{list[z].NAME}이(가) {total - 100}개 초과입니다.");
                }

                // VOL+{txt[z].Text}가 100이상이면 100으로 처리
                // 100이하면 그대로 처리
                cmd.CommandText = $"update ingredient " +
                    $"set VOL = (CASE WHEN VOL+{txt[z].Text} >= 100 THEN 100 " +
                    $"ELSE VOL+{txt[z].Text} END) where ID = {list[z].ID}";
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }
    }
}