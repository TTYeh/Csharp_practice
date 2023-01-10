namespace MyHomework_張佑晨0708
{
	// Token: 0x02000017 RID: 23
	public partial class Myhomework_0718_ScreenSaver : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00014594 File Offset: 0x00012794
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000145CC File Offset: 0x000127CC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MyHomework_張佑晨0708.Myhomework_0718_ScreenSaver));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(35, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(410, 306);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.pictureBox1);
			this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Myhomework_0718_ScreenSaver";
			this.Text = "Myhomework_0718_ScreenSaver";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400016C RID: 364
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400016D RID: 365
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400016E RID: 366
		private global::System.Windows.Forms.Timer timer1;
	}
}
