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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn29_1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textScore.Text);
            if (score >= 90 && score <= 100)
            {
                labelGrade.Text = "A級";
            }
            else if (score >= 80)
            {
                labelGrade.Text = "B級";
            }
            else if (score >= 70)
            {
                labelGrade.Text = "C級";
            }
            else if (score >= 60)
            {
                labelGrade.Text = "D級";
            }
            else
            {
                labelGrade.Text = "E級";
            }
        }

        private void btn29_2_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textScore.Text);
            if (score >= 0 && score <= 100)
            {
                switch (score)
                {
                    case int n when (n >= 90 && n <= 100):
                        labelGrade.Text = "A級";
                        break;
                    case int n when (n >= 80):
                        labelGrade.Text = "B級";
                        break;
                    case int n when (n >= 70):
                        labelGrade.Text = "C級";
                        break;
                    case int n when (n >= 60):
                        labelGrade.Text = "D級";
                        break;
                    case int n when (n >= 0 && n < 60):
                        labelGrade.Text = "E級";
                        break;

                }
            }
            else
            {
                labelGrade.Text = "Out Of Range";
            }
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            string result = "";
            while (i < 10) {
                result +=  i + "\n";
                i ++; 
            }
            MessageBox.Show(result);
        }

        private void btnDoLoop_Click(object sender, EventArgs e)
        {
            int i = 10;
            string result = "";
            do
            {
                result += i + "\n";
                i++;
            } while (i < 10);
            MessageBox.Show(result);
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result += i + "\n";
                // i++;
            }
            for (int j = 0, x = 100, y = 50; j + y < x; j += 3, y--)
            {
                result += $"i={x} , j={j} , y = {y} "+ "\n";

            }

            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // define Array1
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            string result = "";
            for (int i = 0; i < arr.Length; i++) {
                result += arr[i] + "\n";
            }
            // define Array2
            int[] arr2 = new int[3] { 4, 5, 6 };
            for (int i = 0; i < arr2.Length; i++)
            {
                result += arr2[i] + "\n";
            }
            MessageBox.Show(result);
        }

        private void btn_2d_arr_Click(object sender, EventArgs e)
        {
            // define Array1
            int[,] arr = new int[2,3];
            arr[0,0] = 1;
            arr[0,1] = 2;
            arr[0,2] = 3;
            arr[1,0] = 4;
            arr[1,1] = 5;
            arr[1,2] = 6;
            string result = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result += arr[i,j] + "\n";
                }
            }
            MessageBox.Show(result);
            string[,] arr2 = new string[2, 3]
            {
                { "a","b","c"},
                { "d","e","f"}
            };
        }
    }
}
