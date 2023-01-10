using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨0708
{
	// Token: 0x02000018 RID: 24
	public partial class Myhomework_0723_DrawPaint : Form
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00014780 File Offset: 0x00012980
		public Myhomework_0723_DrawPaint()
		{
			this.InitializeComponent();
			this.g = base.CreateGraphics();
			this.label1.Text = string.Concat(this.trackBar1.Value);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000147EC File Offset: 0x000129EC
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.colorDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.p.Color = this.colorDialog1.Color;
				this.label2.BackColor = this.colorDialog1.Color;
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001483C File Offset: 0x00012A3C
		private void Myhomework_0723_DrawPaint_MouseDown(object sender, MouseEventArgs e)
		{
			this.flag = true;
			this.poi.X = e.X;
			this.poi.Y = e.Y;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001486C File Offset: 0x00012A6C
		private void Myhomework_0723_DrawPaint_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.flag;
			if (flag)
			{
				this.g.DrawLine(this.p, this.poi.X, this.poi.Y, e.X, e.Y);
				this.poi.X = e.X;
				this.poi.Y = e.Y;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000148DE File Offset: 0x00012ADE
		private void Myhomework_0723_DrawPaint_MouseUp(object sender, MouseEventArgs e)
		{
			this.flag = false;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000148E8 File Offset: 0x00012AE8
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.label1.Text = string.Concat(this.trackBar1.Value);
			this.p.Width = (float)this.trackBar1.Value;
		}

		// Token: 0x0400016F RID: 367
		private Graphics g;

		// Token: 0x04000170 RID: 368
		private Pen p = new Pen(Color.Black, 1f);

		// Token: 0x04000171 RID: 369
		private Point poi;

		// Token: 0x04000172 RID: 370
		private bool flag = false;
	}
}
