namespace MSIT_Csharp_Quiz_張佑晨
{
	// Token: 0x0200001C RID: 28
	public partial class FormGuessMessageBox : global::System.Windows.Forms.Form
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0001588C File Offset: 0x00013A8C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000158C4 File Offset: 0x00013AC4
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bahnschrift Condensed", 19.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(261, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please input a number.";
			this.textBox1.Location = new global::System.Drawing.Point(12, 101);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(417, 25);
			this.textBox1.TabIndex = 1;
			this.button1.Font = new global::System.Drawing.Font("Bahnschrift Condensed", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(336, 14);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(93, 36);
			this.button1.TabIndex = 2;
			this.button1.Text = "Enter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Font = new global::System.Drawing.Font("Bahnschrift Condensed", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(336, 59);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(93, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(441, 138);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "FormGuessMessageBox";
			this.Text = "Guess";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400018F RID: 399
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000193 RID: 403
		private global::System.Windows.Forms.Button button2;
	}
}
