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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            hw01_Hello helloForm = new hw01_Hello();
            int windowTop = this.panel1.Location.Y + splitContainer1.Size.Height;
            int windowLeft = this.panel1.Location.X + splitContainer1.Size.Width;
            // MessageBox.Show(Convert.ToString(windowTop) +","+ Convert.ToString(windowLeft));
            helloForm.StartPosition = FormStartPosition.Manual;
            helloForm.Left = 310;
            helloForm.Top = 120;
    // 可塞到容器
            // helloForm.StartPosition = FormStartPosition.CenterScreen;
            helloForm.Show();
            
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            /*
            mainForm myMainForm = new mainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            */
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            // note: c#笨，要先new元件出來再用他的資料格式接，先打資料格式出來會抓不到
            hw02_Loan loanForm = new hw02_Loan();
            loanForm.StartPosition = FormStartPosition.Manual;
            loanForm.Left = 310;
            loanForm.Top = 120;
            // helloForm.StartPosition = FormStartPosition.CenterScreen;
            loanForm.Show();
        }

        private void btn_Exam_guessNub_Click(object sender, EventArgs e)
        {
            hw_E1_guessMain guessForm = new hw_E1_guessMain();
            guessForm.Show();
        }
    }
}
