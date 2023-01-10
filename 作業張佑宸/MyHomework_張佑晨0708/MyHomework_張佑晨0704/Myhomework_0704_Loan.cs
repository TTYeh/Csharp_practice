using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MyHomework_張佑晨;

namespace MyHomework_張佑晨0704
{
	// Token: 0x02000003 RID: 3
	public partial class Myhomework_0704_Loan : Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000031F8 File Offset: 0x000013F8
		public Myhomework_0704_Loan()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003210 File Offset: 0x00001410
		private void button1_Click(object sender, EventArgs e)
		{
			this.L = Convert.ToDouble(this.loan.Text) - Convert.ToDouble(this.first.Text);
			this.D = Convert.ToDouble(this.deadline.Text) * 12.0;
			this.R = Convert.ToDouble(this.rate.Text) / 1200.0;
			this.x = Convert.ToInt32(Financial.Pmt(this.R, this.D, this.L, 0.0, DueDate.EndOfPeriod)) * -1;
			MessageBox.Show("月付額：" + this.x + "元");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000032D4 File Offset: 0x000014D4
		private void button2_Click(object sender, EventArgs e)
		{
			this.L = Convert.ToDouble(this.loan.Text) - Convert.ToDouble(this.first.Text);
			this.D = Convert.ToDouble(this.deadline.Text) * 12.0;
			this.R = Convert.ToDouble(this.rate.Text) / 1200.0;
			this.x = Convert.ToInt32(Financial.Pmt(this.R, this.D, this.L, 0.0, DueDate.EndOfPeriod)) * -1;
			MessageBox.Show("總付款：" + (double)this.x * this.D + "元");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000033A0 File Offset: 0x000015A0
		private void loanreport_Click(object sender, EventArgs e)
		{
			Myhomework_0704_LoanReport myhomework_0704_LoanReport = new Myhomework_0704_LoanReport();
			myhomework_0704_LoanReport.labelloan.Text = this.loan.Text;
			myhomework_0704_LoanReport.labelrate.Text = this.rate.Text;
			myhomework_0704_LoanReport.labeldeadline.Text = this.deadline.Text;
			this.L = Convert.ToDouble(this.loan.Text) - Convert.ToDouble(this.first.Text);
			this.D = Convert.ToDouble(this.deadline.Text) * 12.0;
			this.R = Convert.ToDouble(this.rate.Text) / 1200.0;
			this.x = Convert.ToInt32(Financial.Pmt(this.R, this.D, this.L, 0.0, DueDate.EndOfPeriod)) * -1;
			myhomework_0704_LoanReport.labelmonths.Text = string.Format("{0}", this.x);
			myhomework_0704_LoanReport.labeltotal.Text = string.Format("{0}", (double)this.x * this.D);
			myhomework_0704_LoanReport.Show();
		}

		// Token: 0x0400001D RID: 29
		private int x;

		// Token: 0x0400001E RID: 30
		private double L;

		// Token: 0x0400001F RID: 31
		private double D;

		// Token: 0x04000020 RID: 32
		private double R;
	}
}
