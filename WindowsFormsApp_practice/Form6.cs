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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btn29_1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textScore.Text);
            if (score >= 90 && score <= 100)
            {
                labelGrade.Text = "A級";
            }
            else if (score >= 80)
            {
                labelGrade.Text = "B級";
            }
            else if (score >= 70)
            {
                labelGrade.Text = "C級";
            }
            else if (score >= 60)
            {
                labelGrade.Text = "D級";
            }
            else
            {
                labelGrade.Text = "E級";
            }

        }
    }
}
