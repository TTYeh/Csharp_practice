using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int count = 0;
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            display4add.Text = count.ToString();
        }

        private void front_acc_add_btn_Click(object sender, EventArgs e)
        {
            int result = ++count;
            // count += 1
            // int result = count

            front_acc_disp.Text = result.ToString();
        }

        private void back_acc_add_btn_Click(object sender, EventArgs e)
        {
            int result = count++;
            // int result = count
            // count += 1

            back_acc_disp.Text = result.ToString();
        }
    }
}
