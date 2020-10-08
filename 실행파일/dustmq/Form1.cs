using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dustmq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.ToString("yyyy.MM.dd");
            label4.Text = dateTimePicker2.Value.ToString("yyy.MM.dd");
            //comboBox1.Items.Add();
        }
    }
}
