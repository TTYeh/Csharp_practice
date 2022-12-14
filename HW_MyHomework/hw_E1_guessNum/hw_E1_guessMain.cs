using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW_MyHomework.Utility;

namespace HW_MyHomework
{
    public partial class hw_E1_guessMain : Form
    {
        public static hw_E1_guessMain formInstanceMain;
        public static Label labelInstanceMain;
        public hw_E1_guessMain()
        {
            InitializeComponent();
            formInstanceMain = this;
            labelInstanceMain = labelShowMsg;
        }
        // 定義變數? 除utility有更好的方法?

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (! isFormExist())
            {
                hw_E1_guessGuesser guesser = new hw_E1_guessGuesser();
                guesser.Show();
            }
            else
            {
                // TODO:讓已經存在的視窗閃兩下
                hw_E1_guessGuesser.onlyOnceGuessForm.TopMost = true;
                // DialogResult a =  hw_E1_guessGuesser.onlyOnceGuessForm.ShowDialog();
            }
        }
        private bool isFormExist() {
            bool isFormExist = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                //iterate through
                if (frm.Name == "hw_E1_guessGuesser")
                {
                    isFormExist = true;
                }
            }
            return isFormExist;
            // 失敗的嘗試:要確認有無class已經instance了
            /*
            string @namespace = "HW_MyHomework";
            string @class = "hw_E1_guessGuesser";
            var myClassType = Type.GetType(String.Format("{0}.{1}", @namespace, @class));
            object instance = myClassType == null ? null : Activator.CreateInstance(myClassType);
            if (myClassType != null)
            {
            }
            else
            {
                hw_E1_guessGuesser guesser = new hw_E1_guessGuesser();
                guesser.Show();
            }
            */
        }
        private void btnShowAns_Click(object sender, EventArgs e)
        {   
            MessageBox.Show("正確的答案是: " + hw_E1_Utility.answer + "\n 確定後初始化");
            // 初始化answer &　main_label說明的值
            initMainDisp();
            // 目前用不到，委派，因為事件的函式不用被連環執行
            // btnShowAns.Click += new EventHandler(this.hw_E1_guessMain_Load);
        }


        private void hw_E1_guessMain_Load(object sender, EventArgs e)
        {
            // 初始化answer的值
            initMainDisp();
        }

        private void initMainDisp() {

            hw_E1_Utility.answer = new Random().Next(101);
            labelShowMsg.Text = "Please Select A Number Bwteen 1 TO 100";
            hw_E1_Utility.boundLowerLimit = 0;
            hw_E1_Utility.boundUpperLimit = 100;
            hw_E1_Utility.guessCount = 0;
            // 委派結尾???
            // btnShowAns.Click -= new EventHandler(this.hw_E1_guessMain_Load);
        }
    }
}
