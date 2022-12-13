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
        // 定義變數 改用utility
        // static int answer;


        private void btnGuess_Click(object sender, EventArgs e)
        {

            // 要確認有無class已經instance了
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
            // 問題若按視窗x 就沒有isCallGuesser的變數變化了
            if (! isFormExist())
            {
                hw_E1_guessGuesser guesser = new hw_E1_guessGuesser();
                guesser.Show();
                hw_E1_Utility.isCallGuesser = true;
            }
            else
            {
                // TODO:讓已經存在的視窗閃兩下
                // hw_E1_guessGuesser.onlyOnceGuessForm.Show();
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
        }
        private void btnShowAns_Click(object sender, EventArgs e)
        {   
            // 每次都要new一個才能用utility?有點麻煩???????
            MessageBox.Show("正確的答案是: " + hw_E1_Utility.answer + "\n 確定後初始化");

            // 初始化answer &　main_label說明的值
            initMainDisp();
            // 委派再call一次 function ，委派的順序要再確認一下????第二次完全一樣?
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
            hw_E1_Utility.isCallGuesser = false;
            // 委派結尾???
            // btnShowAns.Click -= new EventHandler(this.hw_E1_guessMain_Load);
        }
        public void updateMainDisp()
        {
            labelShowMsg.Text = hw_E1_Utility.dispString;
        }
        private void labelShowMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
