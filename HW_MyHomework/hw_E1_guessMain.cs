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
    public partial class hw_E1_guessMain : Form
    {
        public hw_E1_guessMain()
        {
            InitializeComponent();
        }
        // 定義變數
        static int answer;


        private void btnGuess_Click(object sender, EventArgs e)
        {
            hw_E1_guessGuesser guesser = new hw_E1_guessGuesser();
            guesser.Show();
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {

        }

        
        private void hw_E1_guessMain_Load(object sender, EventArgs e)
        {
            answer = new Random().Next(101);
        }
        public int returnAns() 
        {
            return answer;
        }

        private void labelShowMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
