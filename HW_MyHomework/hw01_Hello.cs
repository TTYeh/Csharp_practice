using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_MyHomework
{
    public partial class hw01_Hello : Form
    {
        public hw01_Hello()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hello_01_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            String nameChinese = inputName.Text;
            String nameEng = inputEngName.Text;
            String sex = inputSex.Text;
            String star = inputStarsign.Text;
            MessageBox.Show(" Hello, 我是: " + nameChinese + 
                "\n 英文名字是" + nameEng +
                "\n 性別是" + sex +
                "\n 星座是" + star +
                "\n 很高興認識你。");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nameChinese = inputName.Text;
            String nameEng = inputEngName.Text;
            String sex = inputSex.Text;
            String star = inputStarsign.Text;
            MessageBox.Show(" Hi, 我是: " + nameChinese +
                "\n 英文名字是" + nameEng +
                "\n 性別是" + sex +
                "\n 星座是" + star +
                "\n 很高興認識你。");
        }

        private void inputStarsignlabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Move(object sender, EventArgs e)
        {
            label1.Text = this.Location.X + "," + this.Location.Y; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
