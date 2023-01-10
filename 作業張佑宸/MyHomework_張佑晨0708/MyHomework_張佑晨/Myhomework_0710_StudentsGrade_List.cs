using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x02000007 RID: 7
	public partial class Myhomework_0710_StudentsGrade_List : Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00006F1C File Offset: 0x0000511C
		public Myhomework_0710_StudentsGrade_List()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006F58 File Offset: 0x00005158
		internal void EnterList()
		{
			this.stug0710.Name = this.Namebox.Text;
			this.stug0710.CH = int.Parse(this.Chibox.Text);
			this.stug0710.EN = int.Parse(this.Enbox.Text);
			this.stug0710.Math = int.Parse(this.Mathbox.Text);
			this.stug0710.Sum = (double)(this.stug0710.CH + this.stug0710.EN + this.stug0710.Math);
			this.stug0710.Avg = this.stug0710.Sum / 3.0;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000701C File Offset: 0x0000521C
		internal void MaxAndMin()
		{
			bool flag = this.stug0710.CH > this.stug0710.EN;
			if (flag)
			{
				bool flag2 = this.stug0710.CH > this.stug0710.Math;
				if (flag2)
				{
					this.stug0710.Max = "國文" + Convert.ToString(this.stug0710.CH);
				}
				else
				{
					this.stug0710.Max = "數學" + Convert.ToString(this.stug0710.Math);
				}
			}
			else
			{
				bool flag3 = this.stug0710.EN > this.stug0710.Math;
				if (flag3)
				{
					bool flag4 = this.stug0710.EN > this.stug0710.CH;
					if (flag4)
					{
						this.stug0710.Max = "英文" + Convert.ToString(this.stug0710.EN);
					}
					else
					{
						this.stug0710.Max = "國文" + Convert.ToString(this.stug0710.CH);
					}
				}
				else
				{
					bool flag5 = this.stug0710.EN > this.stug0710.Math;
					if (flag5)
					{
						this.stug0710.Max = "英文" + Convert.ToString(this.stug0710.EN);
					}
					else
					{
						this.stug0710.Max = "數學" + Convert.ToString(this.stug0710.Math);
					}
				}
			}
			bool flag6 = this.stug0710.CH < this.stug0710.EN;
			if (flag6)
			{
				bool flag7 = this.stug0710.CH < this.stug0710.Math;
				if (flag7)
				{
					this.stug0710.Min = "國文" + Convert.ToString(this.stug0710.CH);
				}
				else
				{
					this.stug0710.Min = "數學" + Convert.ToString(this.stug0710.Math);
				}
			}
			else
			{
				bool flag8 = this.stug0710.EN < this.stug0710.Math;
				if (flag8)
				{
					bool flag9 = this.stug0710.EN < this.stug0710.CH;
					if (flag9)
					{
						this.stug0710.Min = "英文" + Convert.ToString(this.stug0710.EN);
					}
					else
					{
						this.stug0710.Min = "國文" + Convert.ToString(this.stug0710.CH);
					}
				}
				else
				{
					bool flag10 = this.stug0710.EN < this.stug0710.Math;
					if (flag10)
					{
						this.stug0710.Min = "英文" + Convert.ToString(this.stug0710.EN);
					}
					else
					{
						this.stug0710.Min = "數學" + Convert.ToString(this.stug0710.Math);
					}
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00007348 File Offset: 0x00005548
		internal void ShowGrade()
		{
			this.GradeShowLabel.Text = string.Empty;
			for (int i = 0; i < this.GradeList.Count; i++)
			{
				Label gradeShowLabel = this.GradeShowLabel;
				gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", this.GradeList[i].Name, this.GradeList[i].CH, this.GradeList[i].EN) + string.Format("{0,6}{1,6}{2,6:N1}", this.GradeList[i].Math, this.GradeList[i].Sum, this.GradeList[i].Avg) + string.Format("{0,6}{1,6}\n", this.GradeList[i].Min, this.GradeList[i].Max);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00007460 File Offset: 0x00005660
		internal void Notify()
		{
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
					}
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00007530 File Offset: 0x00005730
		private void Save_Click(object sender, EventArgs e)
		{
			this.summury.Enabled = true;
			this.RemoveList.Enabled = true;
			this.Notify();
			this.EnterList();
			this.MaxAndMin();
			this.GradeList.Add(this.stug0710);
			this.ShowGrade();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00007588 File Offset: 0x00005788
		private void InsertSave(object sender, EventArgs e)
		{
			this.summury.Enabled = true;
			this.RemoveList.Enabled = true;
			this.Notify();
			this.EnterList();
			this.MaxAndMin();
			this.GradeList.Insert(0, this.stug0710);
			this.ShowGrade();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000075DF File Offset: 0x000057DF
		private void button4_Click(object sender, EventArgs e)
		{
			this.GradeList.RemoveAt(0);
			this.MaxAndMin();
			this.ShowGrade();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00007600 File Offset: 0x00005800
		private void button2_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.GradeList.Count; i++)
			{
				this.Sta.TtCh = this.Sta.TtCh + (double)this.GradeList[i].CH;
				this.Sta.TtEn = this.Sta.TtEn + (double)this.GradeList[i].EN;
				this.Sta.TtMa = this.Sta.TtMa + (double)this.GradeList[i].Math;
			}
			this.Sta.AVGCh = this.Sta.TtCh / (double)this.GradeList.Count;
			this.Sta.AVGEn = this.Sta.TtEn / (double)this.GradeList.Count;
			this.Sta.AVGMa = this.Sta.TtMa / (double)this.GradeList.Count;
			this.Sta.MINCh = 999;
			this.Sta.MINEn = 999;
			this.Sta.MINMa = 999;
			for (int j = 0; j < this.GradeList.Count; j++)
			{
				bool flag = this.GradeList[j].CH > this.Sta.MAXCh;
				if (flag)
				{
					this.Sta.MAXCh = this.GradeList[j].CH;
				}
				bool flag2 = this.GradeList[j].EN > this.Sta.MAXEn;
				if (flag2)
				{
					this.Sta.MAXEn = this.GradeList[j].EN;
				}
				bool flag3 = this.GradeList[j].Math > this.Sta.MAXMa;
				if (flag3)
				{
					this.Sta.MAXMa = this.GradeList[j].Math;
				}
				bool flag4 = this.GradeList[j].CH < this.Sta.MINCh;
				if (flag4)
				{
					this.Sta.MINCh = this.GradeList[j].CH;
				}
				bool flag5 = this.GradeList[j].EN < this.Sta.MINEn;
				if (flag5)
				{
					this.Sta.MINEn = this.GradeList[j].EN;
				}
				bool flag6 = this.GradeList[j].Math < this.Sta.MINMa;
				if (flag6)
				{
					this.Sta.MINMa = this.GradeList[j].Math;
				}
			}
			this.Statisticslabel.Text = string.Format("總分{0,8} {1,6}{2,6}\n", this.Sta.TtCh, this.Sta.TtEn, this.Sta.TtMa) + string.Format("平均{0,8:N1} {1,6:N1}{2,6:N1}\n", this.Sta.AVGCh, this.Sta.AVGEn, this.Sta.AVGMa) + string.Format("最高分{0,6}{1,6}{2,6}\n", this.Sta.MAXCh, this.Sta.MAXEn, this.Sta.MAXMa) + string.Format("最低分{0,6}{1,6}{2,6}", this.Sta.MINCh, this.Sta.MINEn, this.Sta.MINMa);
			this.summury.Enabled = false;
			this.Save.Enabled = false;
			this.InsertList.Enabled = false;
			this.RemoveList.Enabled = false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00007A04 File Offset: 0x00005C04
		private void button3_Click(object sender, EventArgs e)
		{
			this.GradeList.Clear();
			this.ShowGrade();
			this.Statisticslabel.Text = string.Empty;
			this.Save.Enabled = true;
			this.InsertList.Enabled = true;
			this.RemoveList.Enabled = true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00007A60 File Offset: 0x00005C60
		private void SerchList_Click(object sender, EventArgs e)
		{
			int num = int.Parse(this.textBox1.Text);
			int num2 = int.Parse(this.textBox2.Text);
			this.GradeShowLabel.Text = string.Empty;
			for (int i = 0; i < this.GradeList.Count; i++)
			{
				bool flag = num <= this.GradeList[i].CH && num2 >= this.GradeList[i].CH;
				if (flag)
				{
					Label gradeShowLabel = this.GradeShowLabel;
					gradeShowLabel.Text = gradeShowLabel.Text + string.Format("{0,-6}{1,6}{2,6}", this.GradeList[i].Name, this.GradeList[i].CH, this.GradeList[i].EN) + string.Format("{0,6}{1,6}{2,6:N1}", this.GradeList[i].Math, this.GradeList[i].Sum, this.GradeList[i].Avg) + string.Format("{0,6}{1,6}\n", this.GradeList[i].Min, this.GradeList[i].Max);
				}
			}
		}

		// Token: 0x0400005B RID: 91
		private List<StuGrade> GradeList = new List<StuGrade>();

		// Token: 0x0400005C RID: 92
		private StuGrade stug0710 = default(StuGrade);

		// Token: 0x0400005D RID: 93
		private Statistics Sta = default(Statistics);
	}
}
