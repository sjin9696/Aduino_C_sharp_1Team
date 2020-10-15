using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MESProject.cmdTable;

namespace MESProject.View
{
    // 이상헌
    public partial class UCSelectWorkOrder : UserControl
    {
        DateTime tstart;
        DateTime tend;
        MssqlCmdTable mscmd = new MssqlCmdTable();
        public UCSelectWorkOrder()
        {
            InitializeComponent();
        }

        private void UCSelectWorkOrder_Load(object sender, EventArgs e)
        {
            // 기본화면 1달간 조회 상태로 만들기 위해
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1);
            dateTimePicker2.Value = DateTime.Now;
            //dateTimePicker 날짜 표현 수정사항 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd-dddd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd-dddd";

            //ComboBox 칼럼 추가
            comboBoxSearch.Items.Add("종합");
            comboBoxSearch.Items.Add("담당자");
            comboBoxSearch.Items.Add("제품명");
            comboBoxSearch.Items.Add("업체명");
            comboBoxSearch.Items.Add("LOT 번호");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //2020-10-15 오전 11:34:26 -> 2020-10-15 오전 12:00:00
            tstart = dateTimePicker1.Value.Date;
            Console.WriteLine(tstart);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //2020-10-15 오전 11:34:26 -> 2020-10-16 오전 12:00:00
            tend = dateTimePicker2.Value.Date.AddHours(24);
            Console.WriteLine(tend);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tbt = textBoxSearch.Text;
            string cbt = comboBoxSearch.Text;

            dataGridView1.DataSource = mscmd.doDataTable(tstart, tend, cbt, tbt);
        }
    }
}
