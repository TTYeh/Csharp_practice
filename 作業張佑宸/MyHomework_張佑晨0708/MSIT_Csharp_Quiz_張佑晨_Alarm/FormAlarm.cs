using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MSIT_Csharp_Quiz_張佑晨_Alarm
{
	// Token: 0x02000019 RID: 25
	public partial class FormAlarm : Form
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00014D37 File Offset: 0x00012F37
		public FormAlarm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00014D58 File Offset: 0x00012F58
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.label1.Text = DateTime.Now.ToString("hh:mm:ss");
			this.NowTime = DateTime.Now.ToString("hh時mm分ss秒");
			bool flag = this.AlarmTime == this.NowTime;
			if (flag)
			{
				this.timer2.Enabled = true;
			}
			else
			{
				this.timer2.Enabled = false;
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00014DD1 File Offset: 0x00012FD1
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.AlarmTime = this.maskedTextBox1.MaskedTextProvider.ToString();
			this.BackColor = Color.WhiteSmoke;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00014DF6 File Offset: 0x00012FF6
		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			this.maskedTextBox1.Focus();
			this.maskedTextBox1.SelectAll();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00014E14 File Offset: 0x00013014
		private void timer2_Tick(object sender, EventArgs e)
		{
			bool flag = this.flag;
			if (flag)
			{
				this.BackColor = Color.Red;
			}
			else
			{
				this.BackColor = Color.Black;
			}
			this.flag = !this.flag;
		}

		// Token: 0x04000179 RID: 377
		private string AlarmTime;

		// Token: 0x0400017A RID: 378
		private string NowTime;

		// Token: 0x0400017B RID: 379
		private bool flag = false;
	}
}
