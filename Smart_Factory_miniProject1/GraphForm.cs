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
using System.Windows.Forms.DataVisualization.Charting;
namespace Smart_Factory_miniProject1
{
    public partial class GraphForm : MetroForm
    {
        public GraphForm(string[] x,int[] data)
        {
            InitializeComponent();
            //chart1.Titles.Add("생산량");
            Color[] c = new Color[] { Color.FromArgb(64, 64, 0),Color.FromArgb(255, 128, 128),Color.LemonChiffon
        };
            for (int i=0;i<9;i++)   // for문으로 차트 여러개의 차트 출력
            {
                chart1.Series[0].Points.AddXY(x[i],data[i]); // 차트 한줄 출력해주는 코드
                chart1.Series[0].Points[i].Label = data[i].ToString()+ " 개";
                switch (i%3)
                {
                    case 0: chart1.Series[0].Points[i].Color = c[0]; break;

                    case 1: chart1.Series[0].Points[i].Color = c[1]; break;

                    case 2: chart1.Series[0].Points[i].Color = c[2]; break;
                }
                //chart1.Series[0].Points[0].Color = Color.Red;
            }
            //chart1.Series[0].LegendText = "생산량";   // 차트 이름을 "수학"으로 설정
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("굴림", 8f);
            //chart1.Series[0].Points[0].Color = Color.Red;
            chart1.Series[0].Palette= System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chart1.Series[0].ChartType = SeriesChartType.Column; // 그래프를 라인으로 출력
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
