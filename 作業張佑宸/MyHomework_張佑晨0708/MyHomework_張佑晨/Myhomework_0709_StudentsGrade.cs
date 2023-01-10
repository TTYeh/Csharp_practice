using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x02000006 RID: 6
	public partial class Myhomework_0709_StudentsGrade : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00004EFC File Offset: 0x000030FC
		public Myhomework_0709_StudentsGrade()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00004F4C File Offset: 0x0000314C
		internal void MaxAndMin()
		{
			bool flag = this.stug0709[this.ID].CH > this.stug0709[this.ID].EN;
			if (flag)
			{
				bool flag2 = this.stug0709[this.ID].CH > this.stug0709[this.ID].Math;
				if (flag2)
				{
					this.stug0709[this.ID].Max = "國文" + Convert.ToString(this.stug0709[this.ID].CH);
				}
				else
				{
					this.stug0709[this.ID].Max = "數學" + Convert.ToString(this.stug0709[this.ID].Math);
				}
			}
			else
			{
				bool flag3 = this.stug0709[this.ID].EN > this.stug0709[this.ID].Math;
				if (flag3)
				{
					bool flag4 = this.stug0709[this.ID].EN > this.stug0709[this.ID].CH;
					if (flag4)
					{
						this.stug0709[this.ID].Max = "英文" + Convert.ToString(this.stug0709[this.ID].EN);
					}
					else
					{
						this.stug0709[this.ID].Max = "國文" + Convert.ToString(this.stug0709[this.ID].CH);
					}
				}
				else
				{
					bool flag5 = this.stug0709[this.ID].EN > this.stug0709[this.ID].Math;
					if (flag5)
					{
						this.stug0709[this.ID].Max = "英文" + Convert.ToString(this.stug0709[this.ID].EN);
					}
					else
					{
						this.stug0709[this.ID].Max = "數學" + Convert.ToString(this.stug0709[this.ID].Math);
					}
				}
			}
			bool flag6 = this.stug0709[this.ID].CH < this.stug0709[this.ID].EN;
			if (flag6)
			{
				bool flag7 = this.stug0709[this.ID].CH < this.stug0709[this.ID].Math;
				if (flag7)
				{
					this.stug0709[this.ID].Min = "國文" + Convert.ToString(this.stug0709[this.ID].CH);
				}
				else
				{
					this.stug0709[this.ID].Min = "數學" + Convert.ToString(this.stug0709[this.ID].Math);
				}
			}
			else
			{
				bool flag8 = this.stug0709[this.ID].EN < this.stug0709[this.ID].Math;
				if (flag8)
				{
					bool flag9 = this.stug0709[this.ID].EN < this.stug0709[this.ID].CH;
					if (flag9)
					{
						this.stug0709[this.ID].Min = "英文" + Convert.ToString(this.stug0709[this.ID].EN);
					}
					else
					{
						this.stug0709[this.ID].Min = "國文" + Convert.ToString(this.stug0709[this.ID].CH);
					}
				}
				else
				{
					bool flag10 = this.stug0709[this.ID].EN < this.stug0709[this.ID].Math;
					if (flag10)
					{
						this.stug0709[this.ID].Min = "英文" + Convert.ToString(this.stug0709[this.ID].EN);
					}
					else
					{
						this.stug0709[this.ID].Min = "數學" + Convert.ToString(this.stug0709[this.ID].Math);
					}
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005470 File Offset: 0x00003670
		private void Save_Click(object sender, EventArgs e)
		{
			this.summury.Enabled = true;
			bool flag = this.Namebox.Text == string.Empty;
			if (flag)
			{
				MessageBox.Show("請輸入姓名。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				bool flag2 = this.Chibox.Text == string.Empty;
				if (flag2)
				{
					MessageBox.Show("請輸入國文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					bool flag3 = this.Enbox.Text == string.Empty;
					if (flag3)
					{
						MessageBox.Show("請輸入英文成績", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
					else
					{
						bool flag4 = this.Mathbox.Text == string.Empty;
						if (flag4)
						{
							MessageBox.Show("請輸入數學成績。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
						else
						{
							this.stug0709[this.ID].Name = this.Namebox.Text;
							this.stug0709[this.ID].CH = int.Parse(this.Chibox.Text);
							this.stug0709[this.ID].EN = int.Parse(this.Enbox.Text);
							this.stug0709[this.ID].Math = int.Parse(this.Mathbox.Text);
							this.stug0709[this.ID].Sum = (double)(this.stug0709[this.ID].CH + this.stug0709[this.ID].EN + this.stug0709[this.ID].Math);
							this.stug0709[this.ID].Avg = this.stug0709[this.ID].Sum / 3.0;
							this.MaxAndMin();
							Label gradeShowLabel = this.GradeShowLabel;
							gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", this.stug0709[this.ID].Name, this.stug0709[this.ID].CH, this.stug0709[this.ID].EN) + string.Format("{0,6}{1,6}{2,6:N1}", this.stug0709[this.ID].Math, this.stug0709[this.ID].Sum, this.stug0709[this.ID].Avg) + string.Format("{0,6}{1,6}\n", this.stug0709[this.ID].Min, this.stug0709[this.ID].Max);
							this.ID++;
							bool flag5 = this.ID == 100;
							if (flag5)
							{
								MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								this.Save.Enabled = false;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000057BC File Offset: 0x000039BC
		private void RandomSave(object sender, EventArgs e)
		{
			this.summury.Enabled = true;
			this.stug0709[this.ID].Name = Convert.ToString(this.ID + 1);
			this.stug0709[this.ID].CH = this.R.Next(0, 100);
			this.stug0709[this.ID].EN = this.R.Next(0, 100);
			this.stug0709[this.ID].Math = this.R.Next(0, 100);
			this.stug0709[this.ID].Sum = (double)(this.stug0709[this.ID].CH + this.stug0709[this.ID].EN + this.stug0709[this.ID].Math);
			this.stug0709[this.ID].Avg = this.stug0709[this.ID].Sum / 3.0;
			this.MaxAndMin();
			Label gradeShowLabel = this.GradeShowLabel;
			gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", this.stug0709[this.ID].Name, this.stug0709[this.ID].CH, this.stug0709[this.ID].EN) + string.Format("{0,6}{1,6}{2,8:f1}", this.stug0709[this.ID].Math, this.stug0709[this.ID].Sum, this.stug0709[this.ID].Avg) + string.Format("{0,6}{1,6}\n", this.stug0709[this.ID].Min, this.stug0709[this.ID].Max);
			this.ID++;
			bool flag = this.ID == 100;
			if (flag)
			{
				MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Save.Enabled = false;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005A3C File Offset: 0x00003C3C
		private void button2_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.ID; i++)
			{
				this.Sta.TtCh = this.Sta.TtCh + (double)this.stug0709[i].CH;
				this.Sta.TtEn = this.Sta.TtEn + (double)this.stug0709[i].EN;
				this.Sta.TtMa = this.Sta.TtMa + (double)this.stug0709[i].Math;
			}
			this.Sta.AVGCh = this.Sta.TtCh / (double)this.ID;
			this.Sta.AVGEn = this.Sta.TtEn / (double)this.ID;
			this.Sta.AVGMa = this.Sta.TtMa / (double)this.ID;
			this.Sta.MINCh = 999;
			this.Sta.MINEn = 999;
			this.Sta.MINMa = 999;
			for (int j = 0; j < this.ID; j++)
			{
				bool flag = this.stug0709[j].CH > this.Sta.MAXCh;
				if (flag)
				{
					this.Sta.MAXCh = this.stug0709[j].CH;
				}
				bool flag2 = this.stug0709[j].EN > this.Sta.MAXEn;
				if (flag2)
				{
					this.Sta.MAXEn = this.stug0709[j].EN;
				}
				bool flag3 = this.stug0709[j].Math > this.Sta.MAXMa;
				if (flag3)
				{
					this.Sta.MAXMa = this.stug0709[j].Math;
				}
				bool flag4 = this.stug0709[j].CH < this.Sta.MINCh;
				if (flag4)
				{
					this.Sta.MINCh = this.stug0709[j].CH;
				}
				bool flag5 = this.stug0709[j].EN < this.Sta.MINEn;
				if (flag5)
				{
					this.Sta.MINEn = this.stug0709[j].EN;
				}
				bool flag6 = this.stug0709[j].Math < this.Sta.MINMa;
				if (flag6)
				{
					this.Sta.MINMa = this.stug0709[j].Math;
				}
			}
			this.Statisticslabel.Text = string.Format("總分{0,8} {1,6}{2,6}\n", this.Sta.TtCh, this.Sta.TtEn, this.Sta.TtMa) + string.Format("平均{0,8:N1} {1,6:N1}{2,6:N1}\n", this.Sta.AVGCh, this.Sta.AVGEn, this.Sta.AVGMa) + string.Format("最高分{0,6}{1,6}{2,6}\n", this.Sta.MAXCh, this.Sta.MAXEn, this.Sta.MAXMa) + string.Format("最低分{0,6}{1,6}{2,6}", this.Sta.MINCh, this.Sta.MINEn, this.Sta.MINMa);
			this.summury.Enabled = false;
			this.Save.Enabled = false;
			this.Random.Enabled = false;
			this.Random20.Enabled = false;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005E24 File Offset: 0x00004024
		private void button3_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.ID; i++)
			{
				this.stug0709[i].CH = 0;
				this.stug0709[i].EN = 0;
				this.stug0709[i].Math = 0;
				this.stug0709[i].Sum = 0.0;
				this.stug0709[i].Avg = 0.0;
				this.Sta.AVGCh = 0.0;
				this.Sta.AVGEn = 0.0;
				this.Sta.AVGMa = 0.0;
				this.Sta.TtCh = 0.0;
				this.Sta.TtEn = 0.0;
				this.Sta.TtMa = 0.0;
				this.Sta.MAXCh = 0;
				this.Sta.MAXEn = 0;
				this.Sta.MAXMa = 0;
				this.Sta.MINCh = 0;
				this.Sta.MINEn = 0;
				this.Sta.MINMa = 0;
			}
			this.ID = 0;
			this.GradeShowLabel.Text = string.Empty;
			this.Statisticslabel.Text = string.Empty;
			this.Save.Enabled = true;
			this.Random.Enabled = true;
			this.Random20.Enabled = true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00005FCC File Offset: 0x000041CC
		private void button4_Click(object sender, EventArgs e)
		{
			this.summury.Enabled = true;
			int id = this.ID;
			while (this.ID < id + 20)
			{
				this.stug0709[this.ID].Name = Convert.ToString(this.ID + 1);
				this.stug0709[this.ID].CH = this.R.Next(0, 100);
				this.stug0709[this.ID].EN = this.R.Next(0, 100);
				this.stug0709[this.ID].Math = this.R.Next(0, 100);
				this.stug0709[this.ID].Sum = (double)(this.stug0709[this.ID].CH + this.stug0709[this.ID].EN + this.stug0709[this.ID].Math);
				this.stug0709[this.ID].Avg = this.stug0709[this.ID].Sum / 3.0;
				this.MaxAndMin();
				Label gradeShowLabel = this.GradeShowLabel;
				gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", this.stug0709[this.ID].Name, this.stug0709[this.ID].CH, this.stug0709[this.ID].EN) + string.Format("{0,6}{1,6}{2,8:f1}", this.stug0709[this.ID].Math, this.stug0709[this.ID].Sum, this.stug0709[this.ID].Avg) + string.Format("{0,6}{1,6}\n", this.stug0709[this.ID].Min, this.stug0709[this.ID].Max);
				this.ID++;
			}
			bool flag = this.ID == 100;
			if (flag)
			{
				MessageBox.Show("記憶空間已滿，請先刪除舊有資料。", "警告！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Save.Enabled = false;
			}
		}

		// Token: 0x04000044 RID: 68
		private int ID = 0;

		// Token: 0x04000045 RID: 69
		private StuGrade[] stug0709 = new StuGrade[100];

		// Token: 0x04000046 RID: 70
		private Statistics Sta = default(Statistics);

		// Token: 0x04000047 RID: 71
		private Random R = new Random();
	}
}
