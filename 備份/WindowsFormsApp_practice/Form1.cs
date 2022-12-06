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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //todo 未完成
            string Name = inputName.Text;
            MessageBox.Show("Hello" + Name);
            // 重點:類別的全名引入(using或加入參考)
            // 重點:有錯誤小燈泡可幫忙修正
            System.Windows.Forms.MessageBox.Show("Hello類別的全名" + Name);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
