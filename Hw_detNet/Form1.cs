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
            // https://dotblogs.com.tw/chou/2009/06/04/8666
            // btn_judgeTime.Click += btn_judgeTime_Click;
            btn_judgeTime.PerformClick();
        }

        private void btn_judgeTime_Click(object sender, EventArgs e)
        {
            // 判斷在時間內
            int weekDay = Convert.ToInt32(dateTimePicker1.Value.DayOfWeek);
            int hour = Convert.ToInt32(dateTimePicker1.Value.Hour);
            int minute = Convert.ToInt32(dateTimePicker1.Value.Minute);
            textBoxShow.Text = $"您輸入的時間: {Convert.ToString(dateTimePicker1.Value)} \n在星期: {weekDay} \n小時: {hour} \n分鐘: {minute}";
            /*
            if (IsTradingHours(dateTimePicker1.Value))
            {
                textBoxShow.Text = $"您輸入的時間: {Convert.ToString(dateTimePicker1.Value)} 在營業範圍";
            }
            else {
                textBoxShow.Text = $"您輸入的時間: {Convert.ToString(dateTimePicker1.Value)} 沒有在營業範圍";
            }
            */
        }
        public static bool IsTradingHours(DateTime dt)
        {
            int weekDay = Convert.ToInt32(dt.DayOfWeek);
            int hour = Convert.ToInt32(dt.Hour);
            int minute = Convert.ToInt32(dt.Minute);
            if (Enumerable.Range(1, 5).Contains(weekDay) &&
                Enumerable.Range(8, 5).Contains(hour) &&
                Enumerable.Range(1, 5).Contains(minute))
            {
                return true;
            }
            else 
            { 
                return false;
            }
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

        private void btn_judgePrime_Click(object sender, EventArgs e)
        {
            // 查找該數值到根號的整數有沒有 可整除的餘數
            // 7是不是質數 
            int.TryParse(inputNum.Text, out int userInput);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
