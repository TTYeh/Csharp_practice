using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MSIT_Csharp_Quiz_張佑晨
{
	// Token: 0x0200001C RID: 28
	public partial class FormGuessMessageBox : Form
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x000156B9 File Offset: 0x000138B9
		public FormGuessMessageBox()
		{
			this.InitializeComponent();
			base.CenterToScreen();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000156E8 File Offset: 0x000138E8
		private string Resault()
		{
			return string.Format("\nBetween {0}  and {1}", this.Min, this.Max);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001571A File Offset: 0x0001391A
		private void button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00015724 File Offset: 0x00013924
		private bool TransSuccess()
		{
			return int.TryParse(this.textBox1.Text, out this.GuessNumber);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0001574C File Offset: 0x0001394C
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.TransSuccess() && this.GuessNumber <= this.Max && this.GuessNumber >= this.Min;
			if (flag)
			{
				bool flag2 = this.GuessNumber < Class1.ans;
				if (flag2)
				{
					this.Min = this.GuessNumber;
					Class1.x.label1.Text = "Too Small!!!" + this.Resault();
				}
				else
				{
					bool flag3 = this.GuessNumber > Class1.ans;
					if (flag3)
					{
						this.Max = this.GuessNumber;
						Class1.x.label1.Text = "Too Large!!!" + this.Resault();
					}
					else
					{
						bool flag4 = this.GuessNumber == Class1.ans;
						if (flag4)
						{
							MessageBox.Show(string.Format("Congradulations!!! You got {0}!!!", Class1.ans));
						}
					}
				}
			}
			else
			{
				MessageBox.Show(string.Format("請輸入{0}~{1}之間的數字。", this.Min, this.Max), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			this.textBox1.Focus();
			this.textBox1.SelectAll();
		}

		// Token: 0x0400018C RID: 396
		private int GuessNumber;

		// Token: 0x0400018D RID: 397
		private int Max = 100;

		// Token: 0x0400018E RID: 398
		private int Min = 0;
	}
}
