using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨
{
	// Token: 0x0200000A RID: 10
	public partial class Myhomework_0711_MyClac : Form
	{
		// Token: 0x06000072 RID: 114 RVA: 0x0000CBBF File Offset: 0x0000ADBF
		public Myhomework_0711_MyClac()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000CBD8 File Offset: 0x0000ADD8
		private static double Add(double N1, double N2)
		{
			return N1 + N2;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000CBF0 File Offset: 0x0000ADF0
		private static double Mimus(double N1, double N2)
		{
			return N1 - N2;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000CC08 File Offset: 0x0000AE08
		private static double Multiply(double N1, double N2)
		{
			return N1 * N2;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000CC20 File Offset: 0x0000AE20
		private static double Divided(double N1, double N2)
		{
			return N1 / N2;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000CC35 File Offset: 0x0000AE35
		private static void mesg()
		{
			MessageBox.Show("請輸入數值。");
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000CC44 File Offset: 0x0000AE44
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = double.TryParse(this.textBox1.Text, out this.n1) && double.TryParse(this.textBox2.Text, out this.n2);
			if (flag)
			{
				this.label5.Text = string.Format(" {0}", Myhomework_0711_MyClac.Mimus(this.n1, this.n2));
			}
			else
			{
				Myhomework_0711_MyClac.mesg();
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		private void button3_Click(object sender, EventArgs e)
		{
			bool flag = double.TryParse(this.textBox1.Text, out this.n1) && double.TryParse(this.textBox2.Text, out this.n2);
			if (flag)
			{
				this.label5.Text = string.Format(" {0}", Myhomework_0711_MyClac.Multiply(this.n1, this.n2));
			}
			else
			{
				Myhomework_0711_MyClac.mesg();
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000CD3C File Offset: 0x0000AF3C
		private void button4_Click(object sender, EventArgs e)
		{
			bool flag = double.TryParse(this.textBox1.Text, out this.n1) && double.TryParse(this.textBox2.Text, out this.n2);
			if (flag)
			{
				this.label5.Text = string.Format(" {0:f4}", Myhomework_0711_MyClac.Divided(this.n1, this.n2));
			}
			else
			{
				Myhomework_0711_MyClac.mesg();
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000CDB8 File Offset: 0x0000AFB8
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = double.TryParse(this.textBox1.Text, out this.n1) && double.TryParse(this.textBox2.Text, out this.n2);
			if (flag)
			{
				this.label5.Text = string.Format(" {0}", Myhomework_0711_MyClac.Add(this.n1, this.n2));
			}
			else
			{
				Myhomework_0711_MyClac.mesg();
			}
		}

		// Token: 0x040000B0 RID: 176
		private double n1;

		// Token: 0x040000B1 RID: 177
		private double n2;
	}
}
