using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_detNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_letterChange_Click(object sender, EventArgs e)
        {
            //“Capital A” (大寫A)
            //“Lower Case a” (小寫a)
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            btn_judgeTime.Click += btn_judgeTime_Click;
        }

        private void btn_judgeTime_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = Convert.ToString(dateTimePicker1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void btn_99Multiple_Click(object sender, EventArgs e)
        {
            string result = "";
            MultiplicationTableYtility mulClass = new MultiplicationTableYtility();
            for (int multiplicand = 2; multiplicand <= 9; multiplicand++) {
                for (int multiplier = 1; multiplier <= 9; multiplier++)
                {
                    result += mulClass.mulCalculate(multiplicand, multiplier);
                }
                result += "< ... 這裡要空一行 ...>\n";
            }
            textBoxShow.Text = result.Replace("\n", "\r\n"); ;
            //MessageBox.Show(result);
        }

    }
}
