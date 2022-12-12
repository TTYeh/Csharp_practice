using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void hw_E1_guessGuesser_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                int userGuess = Convert.ToInt32(textBoxInputGuess.Text);
            }
            catch
            {
                MessageBox.Show("Please input number type");
            }
                  
        }
    }
}
