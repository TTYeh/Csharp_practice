using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public hw_E1_guessGuesser()
        {
            InitializeComponent();
        }
        // 定義變數
        // static int answer;
        // static int userGuess;
        // static int boundUpperLimit = 100;
        // static int boundLowerLimit = 0;
        private void hw_E1_guessGuesser_Load(object sender, EventArgs e)
        {
            hw_E1_guessMain guessMainForm= new hw_E1_guessMain();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                hw_E1_Utility.userGuess = Convert.ToInt32(textBoxInputGuess.Text);
                hw_E1_guessMain guessMainForm = new hw_E1_guessMain();
                // 這個有爭議，最後不要這樣用
                // guessMainForm.labelShowMsg.Text = returnUserGuess();
                string test = returnUserGuess();
                guessMainForm.updateMainDisp();
            }
            catch
            {
                MessageBox.Show("Please input number type");
            }
        
        }
        public string returnUserGuess() 
        {
            // 好像這裡可以設定Utility的方法耶?
            string frontWord ="";
            if (hw_E1_Utility.answer > hw_E1_Utility.userGuess) { //若答案60 猜50，新邊界50-100
                hw_E1_Utility.boundLowerLimit = hw_E1_Utility.answer;
                frontWord = "Too Big !!! \n Between " + hw_E1_Utility.boundLowerLimit + "and" + hw_E1_Utility.boundUpperLimit;

            } else if (hw_E1_Utility.answer < hw_E1_Utility.userGuess)
            {
                hw_E1_Utility.boundUpperLimit = hw_E1_Utility.answer;
                frontWord = "Too Small !!! \n Between " + hw_E1_Utility.boundLowerLimit + "and" + hw_E1_Utility.boundUpperLimit;
            } else if (hw_E1_Utility.answer == hw_E1_Utility.userGuess)
            {
                // answer == userGuess
                frontWord = "Right!!! ";
            } else {
                frontWord = "Please Enter Between: " + hw_E1_Utility.boundLowerLimit + "and" + hw_E1_Utility.boundUpperLimit;
                MessageBox.Show(frontWord);
            }

            return frontWord;
        }
    }
}
