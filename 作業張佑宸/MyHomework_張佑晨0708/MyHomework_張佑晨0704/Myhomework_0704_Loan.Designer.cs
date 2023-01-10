namespace MyHomework_張佑晨0704
{
	// Token: 0x02000003 RID: 3
	public partial class Myhomework_0704_Loan : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000034E0 File Offset: 0x000016E0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003518 File Offset: 0x00001718
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.loan = new global::System.Windows.Forms.TextBox();
			this.deadline = new global::System.Windows.Forms.TextBox();
			this.rate = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.first = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.loanreport = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(109, 23);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(128, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "貸款金額";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(109, 82);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(117, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "期限(年)";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(111, 144);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(115, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "利率(%)";
			this.loan.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.loan.Location = new global::System.Drawing.Point(255, 20);
			this.loan.Name = "loan";
			this.loan.Size = new global::System.Drawing.Size(223, 34);
			this.loan.TabIndex = 3;
			this.loan.Text = "100000";
			this.deadline.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.deadline.Location = new global::System.Drawing.Point(255, 82);
			this.deadline.Name = "deadline";
			this.deadline.Size = new global::System.Drawing.Size(223, 34);
			this.deadline.TabIndex = 4;
			this.deadline.Text = "2";
			this.rate.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.rate.Location = new global::System.Drawing.Point(255, 144);
			this.rate.Name = "rate";
			this.rate.Size = new global::System.Drawing.Size(223, 34);
			this.rate.TabIndex = 5;
			this.rate.Text = "10";
			this.button1.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button1.Location = new global::System.Drawing.Point(141, 335);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(165, 57);
			this.button1.TabIndex = 6;
			this.button1.Text = "PMT(月付款)";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button2.Location = new global::System.Drawing.Point(313, 335);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(165, 57);
			this.button2.TabIndex = 7;
			this.button2.Text = "總付款";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.first.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.first.Location = new global::System.Drawing.Point(255, 208);
			this.first.Name = "first";
			this.first.Size = new global::System.Drawing.Size(223, 34);
			this.first.TabIndex = 8;
			this.first.Text = "0";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(111, 208);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(99, 33);
			this.label4.TabIndex = 9;
			this.label4.Text = "頭期款";
			this.loanreport.Font = new global::System.Drawing.Font("Taipei Sans TC Beta", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.loanreport.Location = new global::System.Drawing.Point(546, 335);
			this.loanreport.Name = "loanreport";
			this.loanreport.Size = new global::System.Drawing.Size(165, 57);
			this.loanreport.TabIndex = 10;
			this.loanreport.Text = "Report";
			this.loanreport.UseVisualStyleBackColor = true;
			this.loanreport.Click += new global::System.EventHandler(this.loanreport_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.loanreport);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.first);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.rate);
			base.Controls.Add(this.deadline);
			base.Controls.Add(this.loan);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			base.Name = "Myhomework_0704_Loan";
			this.Text = "貸款金額計算";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000021 RID: 33
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TextBox loan;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.TextBox deadline;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.TextBox rate;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.TextBox first;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Button loanreport;
	}
}
