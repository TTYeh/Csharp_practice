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

        private void callByVal_btn_Click(object sender, EventArgs e)
        {
            int A=10, B=20;
            MessageBox.Show("A: " + A + ", B: " + B);
            int C = B;
            B = 30;
            MessageBox.Show("A: " + A + ", B: " + B + ", C: " + C);
        }
        public class callByRef_ClassA
        {
            public int refNumber;
        }
        public class callByRef_ClassB
        {
            public int refNumber;
        }
        public class callByRef_ClassC
        {
            public int refNumber;
        }

        private void callByRef_btn_Click(object sender, EventArgs e)
        {
            callByRef_ClassA cbf_A = new callByRef_ClassA();
            callByRef_ClassB cbf_B = new callByRef_ClassB();
            cbf_A.refNumber = 10;
            cbf_B.refNumber = 20;
            

            MessageBox.Show("A: " + cbf_A.refNumber + ", B: " + cbf_B.refNumber);
            callByRef_ClassB C = cbf_B;
            cbf_B.refNumber = 30;
            MessageBox.Show("A: " + cbf_A.refNumber + ", B: " + cbf_B.refNumber + ", C: " + C.refNumber);
        }

        private void callByRef_btn2_Click(object sender, EventArgs e)
        {
            TextBox tb = textBox1;
            tb.Text = "Reference Type";
            tb.BackColor = Color.DarkGoldenrod;
            tb.ForeColor = Color.Honeydew;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
