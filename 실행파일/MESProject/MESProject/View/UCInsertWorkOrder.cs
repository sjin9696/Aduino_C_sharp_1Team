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
    public partial class UCInsertWorkOrder : UserControl
    {
        MssqlCmdTable mscmd = new MssqlCmdTable();
        public UCInsertWorkOrder()
        {
            InitializeComponent();
        }
        
        private void btnPush_Click(object sender, EventArgs e) //김완수
        {

            try
            {
                int productQuantity = int.Parse(tbCount.Text);
                string productName = tbProductName.Text;
                string employeeName = tbOrnerName.Text;
                string companyName = tbCustomer.Text;
                string remark = tbNull.Text;
                string startOrder = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                DateTime start = DateTime.Parse(startOrder);

                string endOrder = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                DateTime end = DateTime.Parse(endOrder);
                if (0 <= productQuantity && productQuantity <= 999)
                {
                    mscmd.DBInsert(employeeName, start, end, productName,
                   productQuantity, companyName, remark);
                }
                else
                {
                    MessageBox.Show("0~999의 수량을 입력하세요");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                MessageBox.Show("잘못입력하셨습니다.");
            }
            //Console.WriteLine(startOrder);
            //Console.WriteLine(endOrder);

            //Console.WriteLine(productName);
            //Console.WriteLine(employeeName);
            //Console.WriteLine(companyName);
            //Console.WriteLine(remark);
            //Console.WriteLine(productQuantity + "");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int productQuantity = int.Parse(tbCount.Text);
            string productName = tbProductName.Text;
            string employeeName = tbOrnerName.Text;
            string companyName = tbCustomer.Text;
            string remark = tbNull.Text;
            string startOrder = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string endOrder = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            
            dataGridView1.Rows.Add
                (startOrder, employeeName, endOrder, productName, productQuantity.ToString(), companyName, remark);
        }
    }
}
