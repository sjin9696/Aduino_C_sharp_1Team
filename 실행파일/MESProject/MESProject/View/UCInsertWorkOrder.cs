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
        int i_SelRow;
        int i_SelCol;
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
            tbCount.Text = string.Empty;
            cbProductName.Text = string.Empty;
            tbOrnerName.Text = string.Empty; ;
            tbCustomer.Text = string.Empty; ;
            tbNull.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddDays(7);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "수정")
            {
                btnUpdateFalse.Visible = true;
                btn.Visible = false;
                dgvWorkOrder.ReadOnly = false;
            }
            else if (btn.Text == "수정불가")
            {
                btnUpdateTrue.Visible = true;
                btn.Visible = false;
                dgvWorkOrder.ReadOnly = true;
            }
        }

        private void dgvWorkOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string s;
            int a = 0;
            if (dgvWorkOrder.Columns[e.ColumnIndex].Name.ToString() == "pQ")
            {
                s = dgvWorkOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if(int.TryParse(s, out a))
                {
                    if (a < 0 || 999 < a)
                    {
                        dgvWorkOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                        MessageBox.Show("0~999사이의값을 입력해주세요.");
                    }
                }
                else
                {
                    dgvWorkOrder.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    MessageBox.Show("수량을 다시 입력하세요");
                }
                
            }
        }

        private void dgvWorkOrder_MouseUp(object sender, MouseEventArgs e)
        {
            //동적으로 좌표를 정할경우
            //소스로해야함
            if(e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo info = dgvWorkOrder.HitTest(e.X, e.Y);
                if(info.Type == DataGridViewHitTestType.Cell)
                {
                    ContextMenuStrip mnu = new ContextMenuStrip();
                    ToolStripMenuItem mnuUpdate = new ToolStripMenuItem("Update");
                    ToolStripMenuItem mnuCut = new ToolStripMenuItem("Cut");
                    

                    //Assign event handlers
                    mnuUpdate.Click += new EventHandler(mnuUpdate_Click);
                    mnuCut.Click += new EventHandler(mnuCut_Click);

                    //Add to main context menu
                    mnu.Items.AddRange(new ToolStripItem[] { mnuUpdate, mnuCut });

                    //Assign to datagridview
                    dgvWorkOrder.ContextMenuStrip = mnu;

                    i_SelRow = info.RowIndex;
                    i_SelCol = info.ColumnIndex;
                }
                
            }
            
        }
        private void mnuUpdate_Click(object sender, EventArgs e)
        {//아직구현안됨
            //DataGridView dv = dgvWorkOrder;
            //dgvWorkOrder.ReadOnly = false;
            //Console.WriteLine(i_SelRow+"");
        }
        private void mnuCut_Click(object sender, EventArgs e)
        {
            DataGridView dv = dgvWorkOrder;
            dgvWorkOrder.Rows.Remove(dgvWorkOrder.Rows[i_SelRow]);
        }
       
    }
}
