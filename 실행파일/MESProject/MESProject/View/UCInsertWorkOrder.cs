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
            dateTimePicker2.Value = DateTime.Now.AddDays(7);//일주일추가

        }

        private void btnPush_Click(object sender, EventArgs e) //김완수
        {
            //그리드뷰에NULL값이 있으면 DB업로드시 NULL값있는행은 업로드가 안됨
            try
            {
                foreach (DataGridViewRow item in dgvWorkOrder.Rows)
                {
                    mscmd.DBInsert
                        (
                        dgvWorkOrder.Rows[item.Index].Cells[1].Value.ToString(),//담당자
                        DateTime.Parse(dgvWorkOrder.Rows[item.Index].Cells[0].Value.ToString()),//지시일
                        DateTime.Parse(dgvWorkOrder.Rows[item.Index].Cells[2].Value.ToString()),//기한일
                        dgvWorkOrder.Rows[item.Index].Cells[3].Value as string,//제품명(combobox에 데이터는 이렇게 처리)
                        int.Parse(dgvWorkOrder.Rows[item.Index].Cells[4].Value.ToString()),//제품수량
                        dgvWorkOrder.Rows[item.Index].Cells[5].Value.ToString(),//회사명
                        dgvWorkOrder.Rows[item.Index].Cells[6].Value.ToString()//비고
                        );
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            int productQuantity = 0;
            int.TryParse(tbCount.Text, out productQuantity);
                //////////////////////////이렇게하니까 되네욤////////////////////////
            string productName = cbProductName.SelectedItem as string;
            ///////////////////////////////////////////////////////////////////
            string employeeName = tbOrnerName.Text;
            string companyName = tbCustomer.Text;
            string remark = tbNull.Text;
            string startOrder = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string endOrder = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            
                
            if (0 <= productQuantity && productQuantity <= 999)
            {
                if (productName != null)
                {
                    dgvWorkOrder.Rows.Add
                   (startOrder, employeeName, endOrder, productName, productQuantity.ToString(), companyName, remark);
                    Console.WriteLine(productName);
                }
                else
                {
                    MessageBox.Show("올바른 제품명을 입력하세요.");
                }

            }
            else
            {
                MessageBox.Show("0~999의 수량을 입력하세요");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //클리어는 textbox만클리어?
            //아니면 그리드뷰데이터도 클리어?
            //그리드뷰 데이터 지우는것도 있으면 좋을거같아요!
        }
    }
}
