namespace MSIT_Csharp_Quiz_張佑晨_Alarm
{
	// Token: 0x02000019 RID: 25
	public partial class FormAlarm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00014E5C File Offset: 0x0001305C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00014E94 File Offset: 0x00013094
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.maskedTextBox1 = new global::System.Windows.Forms.MaskedTextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Times New Roman", 22.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(45, 66);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(113, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.maskedTextBox1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new global::System.Drawing.Font("Times New Roman", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.groupBox1.Location = new global::System.Drawing.Point(126, 139);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(549, 283);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select Time";
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new global::System.Drawing.Point(224, 188);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(129, 31);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Set Alarm";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.maskedTextBox1.Location = new global::System.Drawing.Point(213, 136);
			this.maskedTextBox1.Mask = "90時90分90秒";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new global::System.Drawing.Size(159, 34);
			this.maskedTextBox1.TabIndex = 2;
			this.maskedTextBox1.ValidatingType = typeof(global::System.DateTime);
			this.maskedTextBox1.MaskInputRejected += new global::System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(219, 89);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(126, 27);
			this.label3.TabIndex = 1;
			this.label3.Text = "Alarm Time";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(66, 136);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(132, 27);
			this.label2.TabIndex = 0;
			this.label2.Text = "Alarm Time:";
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.timer2.Tick += new global::System.EventHandler(this.timer2_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.WhiteSmoke;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label1);
			base.Name = "FormAlarm";
			this.Text = "Form Alarm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400017C RID: 380
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400017D RID: 381
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400017E RID: 382
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400017F RID: 383
		private global::System.Windows.Forms.MaskedTextBox maskedTextBox1;

		// Token: 0x04000180 RID: 384
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000181 RID: 385
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000182 RID: 386
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000183 RID: 387
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000184 RID: 388
		private global::System.Windows.Forms.Timer timer2;
	}
}
