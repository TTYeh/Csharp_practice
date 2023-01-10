namespace MyHomework_張佑晨0708
{
	// Token: 0x02000018 RID: 24
	public partial class Myhomework_0723_DrawPaint : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00014924 File Offset: 0x00012B24
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0001495C File Offset: 0x00012B5C
		private void InitializeComponent()
		{
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.button1 = new global::System.Windows.Forms.Button();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			base.SuspendLayout();
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button1.Location = new global::System.Drawing.Point(987, 12);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(99, 37);
			this.button1.TabIndex = 0;
			this.button1.Text = "顏色";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.trackBar1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.trackBar1.Location = new global::System.Drawing.Point(1030, 101);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Orientation = global::System.Windows.Forms.Orientation.Vertical;
			this.trackBar1.Size = new global::System.Drawing.Size(56, 202);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.TickFrequency = 5;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			this.label1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(1017, 306);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(69, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			this.label2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.label2.BackColor = global::System.Drawing.Color.Black;
			this.label2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label2.Location = new global::System.Drawing.Point(987, 52);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(99, 46);
			this.label2.TabIndex = 3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1098, 594);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.trackBar1);
			base.Controls.Add(this.button1);
			this.Cursor = global::System.Windows.Forms.Cursors.Cross;
			base.Name = "Myhomework_0723_DrawPaint";
			this.Text = "Myhomework_0723_DrawPaint";
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Myhomework_0723_DrawPaint_MouseDown);
			base.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.Myhomework_0723_DrawPaint_MouseMove);
			base.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.Myhomework_0723_DrawPaint_MouseUp);
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000174 RID: 372
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x04000175 RID: 373
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000176 RID: 374
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x04000177 RID: 375
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000178 RID: 376
		private global::System.Windows.Forms.Label label2;
	}
}
