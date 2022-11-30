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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void btn_register_event_Click(object sender, EventArgs e)
        {   // Point:先手動刪掉designer註冊的click方法  由參考看
            // this.btn_register.Click += new System.EventHandler(this.button1_Click);
            // Point:按鈕的click 按照真的物件命名 += new EventHandler(事件觸發 自己創建的執行方法 )
            TestEvent_btn.Click += new EventHandler(this.TestEvent_btn_Click);
            btn_register02.Click += btn_register02_click;
        }
        private void TestEvent_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("09_A_Click_btn event trigger success !");
        }
        private void btn_register02_click(object sender, EventArgs e)
        {
            MessageBox.Show("09_B_Click_btn event trigger success !");
        }

        private void cancel_register_Click(object sender, EventArgs e)
        {
            TestEvent_btn.Click -= new EventHandler(this.TestEvent_btn_Click);
            btn_register02.Click -= btn_register02_click;
        }
    }
}
