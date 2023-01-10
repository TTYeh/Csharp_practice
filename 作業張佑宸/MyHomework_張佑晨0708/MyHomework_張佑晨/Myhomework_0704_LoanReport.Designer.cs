namespace MyHomework_張佑晨
{
	// Token: 0x02000005 RID: 5
	public partial class Myhomework_0704_LoanReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000046A8 File Offset: 0x000028A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000046E0 File Offset: 0x000028E0
		private void InitializeComponent()
		{
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.labelloan = new global::System.Windows.Forms.Label();
			this.labeldeadline = new global::System.Windows.Forms.Label();
			this.labelrate = new global::System.Windows.Forms.Label();
			this.labelmonths = new global::System.Windows.Forms.Label();
			this.button3 = new global::System.Windows.Forms.Button();
			this.labeltotal = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(159, 247);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(127, 33);
			this.label4.TabIndex = 13;
			this.label4.Text = "月付款：";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(159, 183);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(143, 33);
			this.label3.TabIndex = 12;
			this.label3.Text = "利率(%)：";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(157, 121);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(145, 33);
			this.label2.TabIndex = 11;
			this.label2.Text = "期限(年)：";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(157, 62);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(156, 33);
			this.label1.TabIndex = 10;
			this.label1.Text = "貸款金額：";
			this.labelloan.AutoSize = true;
			this.labelloan.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelloan.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 136);
			this.labelloan.Location = new global::System.Drawing.Point(304, 62);
			this.labelloan.Name = "labelloan";
			this.labelloan.Size = new global::System.Drawing.Size(130, 35);
			this.labelloan.TabIndex = 14;
			this.labelloan.Text = "貸款金額";
			this.labeldeadline.AutoSize = true;
			this.labeldeadline.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labeldeadline.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 136);
			this.labeldeadline.Location = new global::System.Drawing.Point(304, 119);
			this.labeldeadline.Name = "labeldeadline";
			this.labeldeadline.Size = new global::System.Drawing.Size(119, 35);
			this.labeldeadline.TabIndex = 15;
			this.labeldeadline.Text = "期限(年)";
			this.labelrate.AutoSize = true;
			this.labelrate.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelrate.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 136);
			this.labelrate.Location = new global::System.Drawing.Point(304, 181);
			this.labelrate.Name = "labelrate";
			this.labelrate.Size = new global::System.Drawing.Size(117, 35);
			this.labelrate.TabIndex = 16;
			this.labelrate.Text = "利率(%)";
			this.labelmonths.AutoSize = true;
			this.labelmonths.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelmonths.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 136);
			this.labelmonths.Location = new global::System.Drawing.Point(304, 245);
			this.labelmonths.Name = "labelmonths";
			this.labelmonths.Size = new global::System.Drawing.Size(101, 35);
			this.labelmonths.TabIndex = 17;
			this.labelmonths.Text = "月付款";
			this.button3.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button3.Location = new global::System.Drawing.Point(543, 344);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(165, 57);
			this.button3.TabIndex = 18;
			this.button3.Text = "Email";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.labeltotal.AutoSize = true;
			this.labeltotal.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.labeltotal.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 136);
			this.labeltotal.Location = new global::System.Drawing.Point(302, 308);
			this.labeltotal.Name = "labeltotal";
			this.labeltotal.Size = new global::System.Drawing.Size(101, 35);
			this.labeltotal.TabIndex = 20;
			this.labeltotal.Text = "總付款";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(157, 310);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(127, 33);
			this.label6.TabIndex = 19;
			this.label6.Text = "總付款：";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.labeltotal);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.labelmonths);
			base.Controls.Add(this.labelrate);
			base.Controls.Add(this.labeldeadline);
			base.Controls.Add(this.labelloan);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Name = "Myhomework_0704_LoanReport";
			this.Text = "Myhomework_0704_LoanReport";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000038 RID: 56
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400003D RID: 61
		internal global::System.Windows.Forms.Label labelloan;

		// Token: 0x0400003E RID: 62
		internal global::System.Windows.Forms.Label labeldeadline;

		// Token: 0x0400003F RID: 63
		internal global::System.Windows.Forms.Label labelrate;

		// Token: 0x04000040 RID: 64
		internal global::System.Windows.Forms.Label labelmonths;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000042 RID: 66
		internal global::System.Windows.Forms.Label labeltotal;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label label6;
	}
}
