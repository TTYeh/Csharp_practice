using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x0200000B RID: 11
	public partial class Myhomework_0716_XOGame : Form
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		public Myhomework_0716_XOGame()
		{
			this.InitializeComponent();
			foreach (object obj in this.panel1.Controls)
			{
				Button button = (Button)obj;
				button.BackColor = Color.Beige;
				button.Text = "";
				button.Click += this.XOGameButton_Click;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000D64C File Offset: 0x0000B84C
		private void XOGameButton_Click(object sender, EventArgs e)
		{
			bool flag = this.change;
			if (flag)
			{
				((Button)sender).Text = "X";
			}
			else
			{
				((Button)sender).Text = "O";
			}
			this.change = !this.change;
			((Button)sender).Enabled = false;
			bool flag2 = this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button1.Text == this.button2.Text && this.button2.Text == this.button3.Text;
			if (flag2)
			{
				MessageBox.Show(this.button1.Text + " 手獲勝!", "完局!");
				this.reset();
			}
			else
			{
				bool flag3 = this.button1.Text != "" && this.button4.Text != "" && this.button7.Text != "" && this.button1.Text == this.button4.Text && this.button4.Text == this.button7.Text;
				if (flag3)
				{
					MessageBox.Show(this.button1.Text + " 手獲勝!", "完局!");
					this.reset();
				}
				else
				{
					bool flag4 = this.button1.Text != "" && this.button5.Text != "" && this.button9.Text != "" && this.button1.Text == this.button5.Text && this.button5.Text == this.button9.Text;
					if (flag4)
					{
						MessageBox.Show(this.button1.Text + " 手獲勝!", "完局!");
						this.reset();
					}
					else
					{
						bool flag5 = this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button4.Text == this.button5.Text && this.button5.Text == this.button6.Text;
						if (flag5)
						{
							MessageBox.Show(this.button4.Text + " 手獲勝!", "完局!");
							this.reset();
						}
						else
						{
							bool flag6 = this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "" && this.button7.Text == this.button8.Text && this.button8.Text == this.button9.Text;
							if (flag6)
							{
								MessageBox.Show(this.button7.Text + " 手獲勝!", "完局!");
								this.reset();
							}
							else
							{
								bool flag7 = this.button2.Text != "" && this.button5.Text != "" && this.button8.Text != "" && this.button2.Text == this.button5.Text && this.button5.Text == this.button8.Text;
								if (flag7)
								{
									MessageBox.Show(this.button2.Text + " 手獲勝!", "完局!");
									this.reset();
								}
								else
								{
									bool flag8 = this.button3.Text != "" && this.button6.Text != "" && this.button9.Text != "" && this.button3.Text == this.button6.Text && this.button6.Text == this.button9.Text;
									if (flag8)
									{
										MessageBox.Show(this.button3.Text + " 手獲勝!", "完局!");
										this.reset();
									}
									else
									{
										bool flag9 = this.button3.Text != "" && this.button5.Text != "" && this.button7.Text != "" && this.button3.Text == this.button5.Text && this.button5.Text == this.button7.Text;
										if (flag9)
										{
											MessageBox.Show(this.button3.Text + " 手獲勝!", "完局!");
											this.reset();
										}
										else
										{
											bool flag10 = this.button1.Text != "" && this.button2.Text != "" && this.button3.Text != "" && this.button4.Text != "" && this.button5.Text != "" && this.button6.Text != "" && this.button7.Text != "" && this.button8.Text != "" && this.button9.Text != "";
											if (flag10)
											{
												MessageBox.Show("平手! 按下確定重新開始", "完局");
												this.reset();
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		private void reset()
		{
			foreach (object obj in this.panel1.Controls)
			{
				Button button = (Button)obj;
				button.Text = "";
				button.Enabled = true;
			}
			this.change = true;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		private void button10_Click(object sender, EventArgs e)
		{
			this.reset();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000DDBE File Offset: 0x0000BFBE
		private void button11_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040000BE RID: 190
		private bool change = true;
	}
}
