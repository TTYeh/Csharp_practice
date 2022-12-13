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
    public partial class hw02_LoanReport : Form
    {
        public hw02_LoanReport()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hw02_LoanReport_Load(object sender, EventArgs e)
        {
            hw02_Loan mytest =  new hw02_Loan();
            // R_input_loan_money.Text = mytest.test();
            R_input_loan_money.Text = mytest.test().loanTotal;
            R_input_loanYear.Text = mytest.test().loanDurningYear;
            R_input_interstRate.Text = mytest.test().interstRateYear;
            R_monthPay.Text = mytest.test().repaymentMonth;
            R_totalPay.Text = mytest.test().totalPay;
        }
    }
}
