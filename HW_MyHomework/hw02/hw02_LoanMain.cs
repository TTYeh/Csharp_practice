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
    public partial class hw02_Loan : Form
    {
        public hw02_Loan()
        {
            InitializeComponent();
        }
        // 定義變數為何無法定義在這裡?
        // decimal loanTotal = Convert.ToDecimal(input_loan_money.Text); // 貸款總金額
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hw02_Loan_Load(object sender, EventArgs e)
        {

        }
        decimal returnRepaymentMonth()
        {
            /*
            試算公式：
                每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
                (公式中：月利率 ＝ 年利率／12 ； 月數=貸款年期 ｘ 12)
                每月應攤還本金與利息試算：
                平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率 ＝每月應還本金金額＋每月應付利息金額
                每月應付利息金額＝本金餘額×月利率
                每月應還本金金額＝平均每月應攤付本息金額－每月應付利息金額
             */
            decimal loanTotal = Convert.ToDecimal(input_loan_money.Text); // 貸款總金額
            int loanDurningMonth = Convert.ToInt32(input_loanYear.Text) * 12; // 貸款期數
            double interstRate = Convert.ToDouble(input_interstRate.Text) / (12 * 100);// 月利率
            decimal downPayment = Convert.ToDecimal(input_downPayment.Text); // 頭期款

            // 計算本息平均攤還 公式:每月應付本息金額之平均攤還率 ＝{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            double avgAmortization = (Math.Pow((1 + interstRate), loanDurningMonth) * interstRate / (Math.Pow((1 + interstRate), loanDurningMonth) - 1));
            decimal repaymentMonth = Convert.ToDecimal(avgAmortization) * loanTotal;
            return Math.Ceiling(repaymentMonth);
        }
        internal void btn_monthPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("月付額: " + returnRepaymentMonth());
        }

        private void btn_totalPay_Click(object sender, EventArgs e)
        {
            string totalPay = Convert.ToString(returnRepaymentMonth() * Convert.ToInt32(input_loanYear.Text) * 12);
            MessageBox.Show("總付款: " + totalPay);
        }

        public struct reportdata {
            // 問問題要怎麼傳stucture
            public string loanTotal;
            public string loanDurningYear;
            public string interstRateYear;
            public string repaymentMonth;
            public string totalPay;
        }

        public reportdata test()
        {
            reportdata myReportData;
            myReportData.loanTotal = input_loan_money.Text; // 貸款總金額(不扣頭期款)
            myReportData.loanDurningYear = input_loanYear.Text; // 貸款年數
            myReportData.interstRateYear = input_interstRate.Text; // 年利率
            myReportData.repaymentMonth = Convert.ToString(returnRepaymentMonth());
            myReportData.totalPay = Convert.ToString(returnRepaymentMonth() * Convert.ToInt32(input_loanYear.Text) * 12);
            return myReportData;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            hw02_LoanReport loanReport =  new hw02_LoanReport();
            loanReport.Show();
        }
    }
}
