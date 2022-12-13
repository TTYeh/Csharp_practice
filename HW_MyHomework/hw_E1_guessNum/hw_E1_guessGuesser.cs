using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW_MyHomework.Utility;

namespace HW_MyHomework
{
    public partial class hw_E1_guessGuesser : Form
    {
        public static hw_E1_guessGuesser onlyOnceGuessForm;
        public hw_E1_guessGuesser()
        {
            InitializeComponent();
            onlyOnceGuessForm = this;

        }
        // 定義變數:公用變數有競態，還有建議其他的方法?
        // static int answer;
        // static int userGuess;
        // static int boundUpperLimit = 100;
        // static int boundLowerLimit = 0;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isInt = int.TryParse(textBoxInputGuess.Text, out int temp);
            if (isInt) {
                hw_E1_Utility.userGuess = temp;
                // 要確定好更新數值的個體
                hw_E1_guessMain.formInstanceMain.labelShowMsg.Text = returnUserGuess();
                hw_E1_Utility.guessCount += 1;
                // 失敗紀錄:
                // guessMainForm.labelShowMsg.Text = returnUserGuess();
                // guessMainForm.updateMainDisp();
            }
            else
            {
                MessageBox.Show("Please input number type");
                textBoxInputGuess.Focus();
                textBoxInputGuess.Clear();
            }
        
        }
        public string returnUserGuess() 
        {
            string frontWord = hw_E1_guessMain.formInstanceMain.labelShowMsg.Text;
            bool isInRange = (hw_E1_Utility.userGuess <= hw_E1_Utility.boundUpperLimit && hw_E1_Utility.boundLowerLimit <= hw_E1_Utility.userGuess);
            if (hw_E1_Utility.answer > hw_E1_Utility.userGuess && isInRange) { 
                // 使用者猜太小
                hw_E1_Utility.boundLowerLimit = hw_E1_Utility.userGuess;
                frontWord = " Your Guess: " + hw_E1_Utility.userGuess + "\n Too Small !!! \n Between " + hw_E1_Utility.boundLowerLimit + "and" + hw_E1_Utility.boundUpperLimit;

            } else if (hw_E1_Utility.answer < hw_E1_Utility.userGuess && isInRange)
            {
                // 使用者猜太大
                hw_E1_Utility.boundUpperLimit = hw_E1_Utility.userGuess;
                frontWord = " Your Guess: " + hw_E1_Utility.userGuess + "\n Too Big !!! \n Between " + hw_E1_Utility.boundLowerLimit + "and" + hw_E1_Utility.boundUpperLimit;
            } else if (hw_E1_Utility.answer == hw_E1_Utility.userGuess && isInRange)
            {
                // 使用者猜中
                frontWord = " Right!!! Answer is " + hw_E1_Utility.answer + "\nYour Count:" + hw_E1_Utility.guessCount;
            }

            if (!isInRange) {
                // 使用者數值超出範圍
                string mesboxString = "Out of Range! Please Enter Between: " + hw_E1_Utility.boundLowerLimit + "and" + hw_E1_Utility.boundUpperLimit;
                MessageBox.Show(mesboxString, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return frontWord;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
