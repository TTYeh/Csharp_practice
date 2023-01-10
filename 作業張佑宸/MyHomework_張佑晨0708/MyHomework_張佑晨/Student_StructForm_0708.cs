using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x0200000D RID: 13
	public partial class Student_StructForm_0708 : Form
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000E83A File Offset: 0x0000CA3A
		public Student_StructForm_0708()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000E854 File Offset: 0x0000CA54
		private void save_Click(object sender, EventArgs e)
		{
			this.Gra.Name = this.Namebox.Text;
			this.Gra.CH = int.Parse(this.Chibox.Text);
			this.Gra.EN = int.Parse(this.Enbox.Text);
			this.Gra.Math = int.Parse(this.Mathbox.Text);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000E8CC File Offset: 0x0000CACC
		private void show_Click(object sender, EventArgs e)
		{
			this.Gralabel.Text = string.Format("姓名：{0}\n國文：{1}分\n英文：{2}分\n數學：{3}分", new object[]
			{
				this.Gra.Name,
				this.Gra.CH,
				this.Gra.EN,
				this.Gra.Math
			});
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000E940 File Offset: 0x0000CB40
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.Gra.CH > this.Gra.EN;
			if (flag)
			{
				bool flag2 = this.Gra.CH > this.Gra.Math;
				if (flag2)
				{
					this.Gra.Max = "國文" + Convert.ToString(this.Gra.CH);
				}
				else
				{
					this.Gra.Max = "數學" + Convert.ToString(this.Gra.Math);
				}
			}
			else
			{
				bool flag3 = this.Gra.EN > this.Gra.Math;
				if (flag3)
				{
					bool flag4 = this.Gra.EN > this.Gra.CH;
					if (flag4)
					{
						this.Gra.Max = "英文" + Convert.ToString(this.Gra.EN);
					}
					else
					{
						this.Gra.Max = "國文" + Convert.ToString(this.Gra.CH);
					}
				}
				else
				{
					bool flag5 = this.Gra.EN > this.Gra.Math;
					if (flag5)
					{
						this.Gra.Max = "英文" + Convert.ToString(this.Gra.EN);
					}
					else
					{
						this.Gra.Max = "數學" + Convert.ToString(this.Gra.Math);
					}
				}
			}
			bool flag6 = this.Gra.CH < this.Gra.EN;
			if (flag6)
			{
				bool flag7 = this.Gra.CH < this.Gra.Math;
				if (flag7)
				{
					this.Gra.Min = "國文" + Convert.ToString(this.Gra.CH);
				}
				else
				{
					this.Gra.Min = "數學" + Convert.ToString(this.Gra.Math);
				}
			}
			else
			{
				bool flag8 = this.Gra.EN < this.Gra.Math;
				if (flag8)
				{
					bool flag9 = this.Gra.EN < this.Gra.CH;
					if (flag9)
					{
						this.Gra.Min = "英文" + Convert.ToString(this.Gra.EN);
					}
					else
					{
						this.Gra.Min = "國文" + Convert.ToString(this.Gra.CH);
					}
				}
				else
				{
					bool flag10 = this.Gra.EN < this.Gra.Math;
					if (flag10)
					{
						this.Gra.Min = "英文" + Convert.ToString(this.Gra.EN);
					}
					else
					{
						this.Gra.Min = "數學" + Convert.ToString(this.Gra.Math);
					}
				}
			}
			this.MaxMinlabel.Text = string.Concat(new string[]
			{
				"最高科目成績為：",
				this.Gra.Max,
				"分\n最低科目成績為：",
				this.Gra.Min,
				"分"
			});
		}

		// Token: 0x040000CD RID: 205
		private StuGrade Gra;
	}
}
