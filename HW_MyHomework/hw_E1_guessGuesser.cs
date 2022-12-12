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

namespace HW_MyHomework
{
    public partial class hw_E1_guessGuesser : Form
    {
        public hw_E1_guessGuesser()
        {
            InitializeComponent();
        }
        // 定義變數
        static int answer;
        static int userGuess;
        static int boundUpperLimit = 100;
        static int boundLowerLimit = 0;
        private void hw_E1_guessGuesser_Load(object sender, EventArgs e)
        {
            hw_E1_guessMain guessMainForm= new hw_E1_guessMain();
            answer = guessMainForm.returnAns();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                userGuess = Convert.ToInt32(textBoxInputGuess.Text);
                hw_E1_guessMain guessMainForm = new hw_E1_guessMain();
                guessMainForm.labelShowMsg.Text = returnUserGuess();
            }
            catch
            {
                MessageBox.Show("Please input number type");
            }
        
        }
        public string returnUserGuess() 
        {
            string frontWord ="";
            if (answer > userGuess) {
                boundUpperLimit = answer;
                frontWord = "Too Big !!! \n Between " + boundLowerLimit + "and" + boundUpperLimit;

            } else if (answer < userGuess)
            {
                boundLowerLimit = answer;
                frontWord = "Too Small !!! \n Between " + boundLowerLimit + "and" + boundUpperLimit;
            } else if (answer == userGuess)
            {
                // answer == userGuess
                frontWord = "Right!!! ";
            } else {
                frontWord = "Please Enter Between: " + boundLowerLimit + "and" + boundUpperLimit;
                MessageBox.Show(frontWord);
            }

            return frontWord;
        }
    }
}
