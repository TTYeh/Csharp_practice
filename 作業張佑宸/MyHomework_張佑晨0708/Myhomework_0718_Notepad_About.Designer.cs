namespace MyHomework_張佑晨0708
{
	// Token: 0x02000016 RID: 22
	public partial class Myhomework_0718_Notepad_About : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00014258 File Offset: 0x00012458
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00014290 File Offset: 0x00012490
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 19.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(87, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "關於";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(17, 76);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0, 15);
			this.label2.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(405, 157);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Myhomework_0718_Notepad_About";
			this.Text = "關於";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000164 RID: 356
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000165 RID: 357
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000166 RID: 358
		private global::System.Windows.Forms.Label label2;
	}
}
