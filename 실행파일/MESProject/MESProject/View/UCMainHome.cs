using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MESProject.DBConnect;

namespace MESProject.View
{
    public partial class UCMainHome : UserControl
    {
        public UCMainHome()
        {
            InitializeComponent();

            chartData.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            chartData.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
        }

        public DataSet GetTblWork()
        {
            SqlConnection conn = DataSources.getConnection();
            // 임시 지시서데이터로 출력 - 수정필
            SqlCommand cmd = new SqlCommand
                ("select productName, sum (productionQuantity) from OrderTable group by productName;", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            DataSources.setClose();
            return ds;
        }

        int[] ledCnt = new int[3];
        int i = 0;
        int sumCnt = 0;
        float perCnt1 = 0;
        float perCnt2 = 0;
        float perCnt3 = 0;

        private void UCMainHome_Load(object sender, EventArgs e) //운수 -> 진영 -> 은수
        {
            try
            {
                DataSet ds = GetTblWork();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    // 데이터베이스 칼럼 수정필
                    string pNameTableRow = row[0].ToString();

                    List<string> pLightList = new List<string> { "light_001", "light_002", "light_003" };
                    if (pLightList.Contains(pNameTableRow))
                    {
                        Console.WriteLine("UCMainHome_Load: 56 LINE " + row[1].ToString());
                        Console.WriteLine("UCMainHome_Load: 56 LINE " + row[0].ToString());
                        ledCnt[i] = int.Parse(row[1].ToString());
                        chartData.Series[0].Points.AddXY(row[0], row[1]);
                        i++;
                    }
                }

                sumCnt = ledCnt[0] + ledCnt[1] + ledCnt[2];

                perCnt1 = float.Parse(ledCnt[0].ToString()) / float.Parse(sumCnt.ToString());
                perCnt2 = float.Parse(ledCnt[1].ToString()) / float.Parse(sumCnt.ToString());
                perCnt3 = float.Parse(ledCnt[2].ToString()) / float.Parse(sumCnt.ToString());

                lbProductCount1.Text = ledCnt[0].ToString();
                lbProductCount2.Text = ledCnt[1].ToString();
                lbProductCount3.Text = ledCnt[2].ToString();

                lbProductPercent1.Text = string.Format("{0:P1}", perCnt1);
                lbProductPercent2.Text = string.Format("{0:P1}", perCnt2);
                lbProductPercent3.Text = string.Format("{0:P1}", perCnt3);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine("동작");
            chartData.Series[0].Points.Clear();
            DataSet ds = GetTblWork();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                // 데이터베이스 칼럼 수정필
                //Console.WriteLine(row[4].ToString() + row[5].ToString() + "");
                chartData.Series[0].Points.AddXY(row[0], row[1]);
            }
        }
    }
}
