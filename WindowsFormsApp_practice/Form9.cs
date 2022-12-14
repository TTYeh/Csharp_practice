using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_practice
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A = "AAA";
            string B = A; // 字串不可被修改的特性
            A = "BBB";
            MessageBox.Show($"A : {A} , B : {B}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 資料量大 + 短時間變動多次  直接用stringBuilder傳址
            StringBuilder sb = new StringBuilder();
            sb.Append("aaaaa");
            MessageBox.Show("stringBuilder A"+ sb.ToString());

            StringBuilder sb2 = sb;
            sb2.Append("bbbbb");
            MessageBox.Show("stringBuilder A" + sb.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // string dir = "C:\\Users\\User\\Desktop\\cSharp_solveConflict\\Csharp_practice\\source\\hw_dotnew_prepare\\1.jpg";
            string dir = @"C:\Users\User\Desktop\cSharp_solveConflict\Csharp_practice\source\hw_dotnew_prepare\1.jpg";
            string result = "";
            result += Path.GetFullPath(dir) + "\n";
            result += Path.GetFileName(dir) + "\n";
            result += Path.GetExtension(dir) + "\n";
            result += Path.GetFileNameWithoutExtension(dir) + "\n";
            MessageBox.Show(result);
        }
    }
}
