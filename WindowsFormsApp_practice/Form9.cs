using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 任意的位置是 10進制度
            // 任意的位置是 a-z
            // 任意的位置是 A-Z
            // 總共有8-16個數字
            labelcheckPassword.Text = !checkPassword(textBox1.Text) ? "密碼強度低" : "密碼強度高";
            labelCheckId.Text = !checkId(textBox2.Text) ? "身分證格式錯" : "身分證格式正確";
            //labelcheckPassword.Text = Convert.ToString( checkPassword(textBox1.Text));
            //labelCheckId.Text = Convert.ToString(checkId(textBox2.Text));

        }
        bool checkPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}");
        }
        bool checkId(string id)
        {
            return Regex.IsMatch(id, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void readFile(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader("test.txt", Encoding.Default);
            //Encoding.UTF8
            textBox3.Text = strRead.ReadToEnd();
            strRead.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\write.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs, Encoding.Default);
            streamWriter.Write(textBox3.Text);
            streamWriter.Close();
            fs.Close();
        }
    }
}
