using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // user Regex
            string userInput = textBox1.Text;
            StringBuilder output = new StringBuilder();
            bool firstEle = true;
            foreach (char c in userInput)
            {
                if (char.IsUpper(c) && firstEle)
                {
                    output.Append(Char.ToLower(c));
                }
                else if (char.IsUpper(c))
                {
                    output.Append("_" + Char.ToLower(c));
                }
                else
                {
                    output.Append(Char.ToLower(c));
                }
                firstEle = false;
            }
            textBoxShow.Text = output.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // https://dotblogs.com.tw/chou/2009/06/04/8666
            // btn_judgeTime.Click += btn_judgeTime_Click;
            // btn_judgeTime.PerformClick();
        }

        private void btn_judgeTime_Click(object sender, EventArgs e)
        {
            // 判斷在時間內

            int weekDay = Convert.ToInt32(dateTimePicker1.Value.DayOfWeek);
            int hour = Convert.ToInt32(dateTimePicker1.Value.Hour);
            int minute = Convert.ToInt32(dateTimePicker1.Value.Minute);
            // string result = $"您輸入的時間: {Convert.ToString(dateTimePicker1.Value)} \n在星期: {weekDay} \n小時: {hour} \n分鐘: {minute} \r\n";
            string result = "";
            if (IsTradingHours(dateTimePicker1.Value))
            {
                result += $"您輸入的時間: {Convert.ToString(dateTimePicker1.Value)} 在營業範圍";
            }
            else {
                result += $"您輸入的時間: {Convert.ToString(dateTimePicker1.Value)} 沒有在營業範圍";
            }
            textBoxShow.Text = result;
        }
        public static bool IsTradingHours(DateTime dt)
        {
            string msg = "";
            int weekDay = Convert.ToInt32(dt.DayOfWeek);
            int hour = Convert.ToInt32(dt.Hour);
            int minute = Convert.ToInt32(dt.Minute);
			
			/*
            msg += $"{Enumerable.Range(1, 5).Contains(weekDay)} \r\n";
            msg += $"{9 <= hour && 13>=hour} \r\n";
            msg += $"{0 <= minute && 29>= minute && hour == 13} \r\n";
            msg += $"{(9 <= hour && 13 >= hour) || 0 <= minute && 29 >= minute && hour == 13} ";
            // MessageBox.Show(msg);
            */
            if (Enumerable.Range(1, 5).Contains(weekDay) &&
                (9 <= hour && 12 >= hour)
            ) {
                return true;
            }
            else if (Enumerable.Range(1, 5).Contains(weekDay) && 13 == hour && minute<30)
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
            dateTimePicker1.CustomFormat = "MM/dd/yyyy tt HH:mm:ss";
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
            bool isPrime = true;
            try
            {
                int.TryParse(inputNum.Text, out int userInput);
                int searchBound = Convert.ToInt32(Math.Ceiling(Math.Pow(userInput, 0.5)));
                if (userInput < 1)
                {
                    textBoxShow.Text = $"使用者輸入: {inputNum.Text}，不是大於1正整數1。母湯喔!";
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i <= searchBound; i++)
                    {
                        if (userInput % i == 0)
                        {
                            textBoxShow.Text = $"使用者輸入: {userInput}不是質數";
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    // 最後都沒被整除就是質數
                    textBoxShow.Text = $"使用者輸入: {userInput}是質數";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("不是大於1正整數1。母湯喔");
            }
            
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LeftStar_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 5; i++ ) {
                result += new string('＊', i); // "" 是string，''是char
                result += "\r\n";
            }
            textBoxShow.Text = result;
        }

        private void btnRightStar_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 5; i++)
            {
                int temp = 5 - i;
                result += new string('　', temp);
                result += new string('＊', i); // "" 是string，''是char
                result += "\r\n";
            }
            textBoxShow.Text = result;
        }

        private void btnMidStar_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 5; i++)
            {
                int temp = 5 - i;
                result += new string('　', temp);
                result += new string('＊', 2*(i-1)+1); // "" 是string，''是char
                result += "\r\n";
            }
            textBoxShow.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((10/4.0).ToString()); //
        }
    }
}
