using MESProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            UCMainHome uCMainHome = new UCMainHome();
            UCInsertWorkOrder uCInsertWorkOrder = new UCInsertWorkOrder();
            UCSelectWorkOrder uCSelectWorkOrder = new UCSelectWorkOrder();
            UCSelectWorkComplete uCSelectWorkComplete = new UCSelectWorkComplete();
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucMainHome1.BringToFront();
        }

        private void btnWOinsert_Click(object sender, EventArgs e)
        {
            ucInsertWorkOrder1.BringToFront();
        }

        private void btnWOSelect_Click(object sender, EventArgs e)
        {
            ucSelectWorkOrder1.BringToFront();
        }

        private void btnWCSelect_Click(object sender, EventArgs e)
        {
            ucSelectWorkComplete1.BringToFront();
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
