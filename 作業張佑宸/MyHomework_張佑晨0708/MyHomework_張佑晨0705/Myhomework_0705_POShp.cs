using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨0705
{
	// Token: 0x02000002 RID: 2
	public partial class Myhomework_0705_POShp : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Myhomework_0705_POShp()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000208C File Offset: 0x0000028C
		private void ClearList_Click(object sender, EventArgs e)
		{
			this.ChList.Text = "尚未點餐";
			this.Totalpc = 0;
			this.Price.Text = "NT$ " + this.Totalpc;
			this.BS = 0;
			this.TS = 0;
			this.WhS = 0;
			this.WiS = 0;
			this.BL = string.Empty;
			this.TL = string.Empty;
			this.WhL = string.Empty;
			this.WiL = string.Empty;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000211C File Offset: 0x0000031C
		private void Bear_Click(object sender, EventArgs e)
		{
			this.BS++;
			this.Totalpc += 120;
			this.Price.Text = "NT$ " + this.Totalpc;
			bool flag = this.BS > 0;
			if (flag)
			{
				this.BL = string.Concat(new object[]
				{
					"啤酒Beer x",
					this.BS,
					",共NT$ ",
					this.BS * 120,
					" 元\n"
				});
			}
			else
			{
				this.BL = string.Empty;
			}
			this.ChList.Text = this.BL + this.TL + this.WhL + this.WiL;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021F8 File Offset: 0x000003F8
		private void Tequila_Click(object sender, EventArgs e)
		{
			this.TS++;
			this.Totalpc += 180;
			this.Price.Text = "NT$ " + this.Totalpc;
			bool flag = this.TS > 0;
			if (flag)
			{
				this.TL = string.Concat(new object[]
				{
					"龍舌蘭Tequila x",
					this.TS,
					",共NT$ ",
					this.TS * 180,
					" 元\n"
				});
			}
			else
			{
				this.TL = string.Empty;
			}
			this.ChList.Text = this.BL + this.TL + this.WhL + this.WiL;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022DC File Offset: 0x000004DC
		private void Whisky_Click(object sender, EventArgs e)
		{
			this.WhS++;
			this.Totalpc += 350;
			this.Price.Text = "NT$ " + this.Totalpc;
			bool flag = this.WhS > 0;
			if (flag)
			{
				this.WhL = string.Concat(new object[]
				{
					"威土忌Whisky x",
					this.WhS,
					",共NT$ ",
					this.WhS * 350,
					" 元\n"
				});
			}
			else
			{
				this.WhL = string.Empty;
			}
			this.ChList.Text = this.BL + this.TL + this.WhL + this.WiL;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023C0 File Offset: 0x000005C0
		private void Wine_Click(object sender, EventArgs e)
		{
			this.WiS++;
			this.Totalpc += 320;
			this.Price.Text = "NT$ " + this.Totalpc;
			bool flag = this.WiS > 0;
			if (flag)
			{
				this.WiL = string.Concat(new object[]
				{
					"紅酒Wine x",
					this.WiS,
					",共NT$ ",
					this.WiS * 320,
					" 元\n"
				});
			}
			else
			{
				this.WiL = string.Empty;
			}
			this.ChList.Text = this.BL + this.TL + this.WhL + this.WiL;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000024A4 File Offset: 0x000006A4
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.Totalpc < 1;
			if (flag)
			{
				MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show("總金額：NT$" + this.Totalpc, "確認付款", MessageBoxButtons.OKCancel);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000024FC File Offset: 0x000006FC
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.Totalpc < 1;
			if (flag)
			{
				MessageBox.Show("尚未點餐！", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MessageBox.Show(string.Concat(new object[]
				{
					"總金額：NT$ ",
					this.Totalpc,
					"\n折扣後金額：NT$ ",
					(double)this.Totalpc * 0.9
				}), "確認付款", MessageBoxButtons.OKCancel);
			}
		}

		// Token: 0x04000001 RID: 1
		private string BL;

		// Token: 0x04000002 RID: 2
		private string TL;

		// Token: 0x04000003 RID: 3
		private string WhL;

		// Token: 0x04000004 RID: 4
		private string WiL;

		// Token: 0x04000005 RID: 5
		private const int Bpc = 120;

		// Token: 0x04000006 RID: 6
		private const int Tpc = 180;

		// Token: 0x04000007 RID: 7
		private const int WHpc = 350;

		// Token: 0x04000008 RID: 8
		private const int WIpc = 320;

		// Token: 0x04000009 RID: 9
		private int Totalpc = 0;

		// Token: 0x0400000A RID: 10
		private int BS = 0;

		// Token: 0x0400000B RID: 11
		private int TS = 0;

		// Token: 0x0400000C RID: 12
		private int WhS = 0;

		// Token: 0x0400000D RID: 13
		private int WiS = 0;
	}
}
