using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨0708
{
	// Token: 0x02000017 RID: 23
	public partial class Myhomework_0718_ScreenSaver : Form
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0001442B File Offset: 0x0001262B
		public Myhomework_0718_ScreenSaver()
		{
			this.InitializeComponent();
			base.MouseMove += this.Myhomework_0718_ScreenSaver_MouseMove;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001446C File Offset: 0x0001266C
		private void Picture(PictureBox pic, ref int gowhere, ref int upwhere)
		{
			pic.Left += gowhere;
			pic.Top += upwhere;
			bool flag = pic.Left + pic.Width > base.Width || pic.Left < 0;
			if (flag)
			{
				gowhere = -gowhere;
			}
			bool flag2 = pic.Top + pic.Height > base.Height || pic.Top < 0;
			if (flag2)
			{
				upwhere = -upwhere;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000144F2 File Offset: 0x000126F2
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Picture(this.pictureBox1, ref this.gowhere, ref this.upwhere);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00014510 File Offset: 0x00012710
		private void Myhomework_0718_ScreenSaver_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.exit;
			if (flag)
			{
				this.mouseX = e.X;
				this.mouseY = e.Y;
				this.exit = !this.exit;
			}
			else
			{
				bool flag2 = Math.Abs(e.X - this.mouseX) > 100 || Math.Abs(e.Y - this.mouseY) > 100;
				if (flag2)
				{
					base.Close();
				}
			}
		}

		// Token: 0x04000167 RID: 359
		private int mouseX;

		// Token: 0x04000168 RID: 360
		private int mouseY;

		// Token: 0x04000169 RID: 361
		private int gowhere = 2;

		// Token: 0x0400016A RID: 362
		private int upwhere = 2;

		// Token: 0x0400016B RID: 363
		private bool exit = true;
	}
}
