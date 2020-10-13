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
using System.Diagnostics;

namespace MESProject.View
{
    public partial class UCSelectWorkOrder : UserControl
    {
        DateTime tstart;
        DateTime tend;
        MainDataSource mds = new MainDataSource();
        public UCSelectWorkOrder()
        {
            InitializeComponent();
        }

        private void UCSelectWorkOrder_Load(object sender, EventArgs e)
        {
            //dateTimePicker 날짜 표현 수정사항 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd-dddd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd-dddd";

            //ComboBox 칼럼 추가
            comboBoxSearch.Items.Add("담당자");
            comboBoxSearch.Items.Add("제품명");
            comboBoxSearch.Items.Add("LOT 번호");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tstart = dateTimePicker1.Value;
            Console.WriteLine(tstart);
      
            //return 
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            tend = dateTimePicker2.Value;
            Console.WriteLine(tend);
        }

        // 이상헌 조회 버튼 클릭 시 datagridview 표시
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(dt1 + "  " + dt2);

            string tbt = textBoxSearch.Text;
            string cbt = comboBoxSearch.Text;

            dataGridView1.DataSource = mds.doDataTable(tstart, tend, cbt,tbt);

            //mds.doDataTable().Rows

        }
    }
}
