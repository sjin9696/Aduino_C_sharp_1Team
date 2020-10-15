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
    public partial class UCSelectWorkOrder : UserControl
    {
        MssqlCmdTable mscmd = new MssqlCmdTable();
        public UCSelectWorkOrder()
        {
            InitializeComponent();

            cbSearch.Text = "종합";
            dtpFirstDate.Value = DateTime.Now.AddMonths(-1);
        }
    }
}
