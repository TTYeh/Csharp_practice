namespace MSIT_Csharp_Quiz_張佑晨
{
	// Token: 0x0200001B RID: 27
	public partial class FormGuess : global::System.Windows.Forms.Form
	{
		// Token: 0x060000EF RID: 239 RVA: 0x000153EC File Offset: 0x000135EC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00015424 File Offset: 0x00013624
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Bahnschrift Condensed", 19.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(12, 83);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(463, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please Select A Number Between 1 to 100!";
			this.button1.Font = new global::System.Drawing.Font("Bahnschrift Condensed", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.Location = new global::System.Drawing.Point(109, 177);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(133, 66);
			this.button1.TabIndex = 1;
			this.button1.Text = "Guess";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.button2.Font = new global::System.Drawing.Font("Bahnschrift Condensed", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.Location = new global::System.Drawing.Point(263, 177);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(199, 66);
			this.button2.TabIndex = 2;
			this.button2.Text = "Show Answer";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click_1);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(611, 387);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Name = "FormGuess";
			this.Text = "Form Guess Number";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000188 RID: 392
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000189 RID: 393
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400018A RID: 394
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400018B RID: 395
		internal global::System.Windows.Forms.Label label1;
	}
}
