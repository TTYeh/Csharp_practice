using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyHomework_張佑晨0708
{
	// Token: 0x02000014 RID: 20
	public partial class MyHomework_0722_PictureViewer : Form
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00011534 File Offset: 0x0000F734
		public MyHomework_0722_PictureViewer()
		{
			this.InitializeComponent();
			foreach (object obj in this.flowLayoutPanel1.Controls)
			{
				Control control = (Control)obj;
				bool flag = control is PictureBox;
				if (flag)
				{
					control.Click += this.X_Click;
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000115C8 File Offset: 0x0000F7C8
		private void X_Click(object sender, EventArgs e)
		{
			new Form
			{
				BackgroundImage = ((PictureBox)sender).Image,
				BackgroundImageLayout = ImageLayout.Zoom
			}.Show();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000115FD File Offset: 0x0000F7FD
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}
	}
}
