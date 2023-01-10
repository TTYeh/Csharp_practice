namespace MyHomework_張佑晨
{
	// Token: 0x0200000A RID: 10
	public partial class Myhomework_0711_MyClac : global::System.Windows.Forms.Form
	{
		// Token: 0x0600007C RID: 124 RVA: 0x0000CE34 File Offset: 0x0000B034
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000CE6C File Offset: 0x0000B06C
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(80, 73);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(76, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Num1:";
			this.textBox1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBox1.Location = new global::System.Drawing.Point(162, 70);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(120, 34);
			this.textBox1.TabIndex = 1;
			this.textBox2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBox2.Location = new global::System.Drawing.Point(162, 122);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(120, 34);
			this.textBox2.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label2.Location = new global::System.Drawing.Point(80, 125);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(76, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Num2:";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label3.Location = new global::System.Drawing.Point(49, 159);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(252, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "================";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label4.Location = new global::System.Drawing.Point(70, 184);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(86, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Answer:";
			this.label5.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label5.Location = new global::System.Drawing.Point(162, 183);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(120, 32);
			this.label5.TabIndex = 6;
			this.button1.Location = new global::System.Drawing.Point(288, 41);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(66, 34);
			this.button1.TabIndex = 7;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(288, 81);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(66, 34);
			this.button2.TabIndex = 8;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.Location = new global::System.Drawing.Point(288, 133);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(66, 34);
			this.button3.TabIndex = 9;
			this.button3.Text = "*";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.Location = new global::System.Drawing.Point(288, 182);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(66, 34);
			this.button4.TabIndex = 10;
			this.button4.Text = "/";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(419, 253);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Name = "Myhomework_0711_MyClac";
			this.Text = "Myhomework_0711_MyClac";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000B2 RID: 178
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Button button4;
	}
}
