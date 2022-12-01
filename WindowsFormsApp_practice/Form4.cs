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

        InstanceAndStatic ins = new InstanceAndStatic();
        private void InstanceVar_btn_Click(object sender, EventArgs e)
        {
            // 18.跨類別共同引入公用類別的Static變數 (Instance不會保留在記憶體共用)
            ins.instanceNumber += 2;
            Instance_label.Text = "Instance Count:  " + ins.instanceNumber;
        }

        private void staticVar_btn_Click(object sender, EventArgs e)
        {
            // 18.跨類別共同引入公用類別的Static變數 (Instance不會保留在記憶體共用)
            InstanceAndStatic.staticNumber += 2;
            static_label.Text = "Static Count:  " + InstanceAndStatic.staticNumber;

        }

        private void localVariable_Click(object sender, EventArgs e)
        {
            // 17.同區域可以存區域變數，同類別可以存類別變數
            // 18.跨類別共同引入公用類別的Static變數 (Instance不會保留在記憶體共用)
        }


        private void HelloFormCallStaticVar_Click(object sender, EventArgs e)
        {
            // 18.跨類別共同引入公用類別的Static變數 (Instance不會保留在記憶體共用)
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
