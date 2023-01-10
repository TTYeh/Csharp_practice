namespace MyHomework_張佑晨
{
	// Token: 0x02000008 RID: 8
	public partial class Myhomework_0711_Method : global::System.Windows.Forms.Form
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00009500 File Offset: 0x00007700
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00009538 File Offset: 0x00007738
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.labelResult = new global::System.Windows.Forms.Label();
			this.Clearbutton = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.button11 = new global::System.Windows.Forms.Button();
			this.button12 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(81, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number:";
			this.textBox1.Font = new global::System.Drawing.Font("新細明體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBox1.Location = new global::System.Drawing.Point(99, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(82, 28);
			this.textBox1.TabIndex = 1;
			this.button1.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button1.Location = new global::System.Drawing.Point(14, 52);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(166, 57);
			this.button1.TabIndex = 2;
			this.button1.Text = "輸入的數為奇數或偶數?";
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label2.Location = new global::System.Drawing.Point(311, 225);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(102, 35);
			this.label2.TabIndex = 3;
			this.label2.Text = "Result:";
			this.labelResult.AutoSize = true;
			this.labelResult.BackColor = global::System.Drawing.Color.LemonChiffon;
			this.labelResult.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.labelResult.ForeColor = global::System.Drawing.Color.Gray;
			this.labelResult.Location = new global::System.Drawing.Point(419, 232);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new global::System.Drawing.Size(52, 25);
			this.labelResult.TabIndex = 4;
			this.labelResult.Text = "結果";
			this.Clearbutton.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Clearbutton.Location = new global::System.Drawing.Point(199, 232);
			this.Clearbutton.Name = "Clearbutton";
			this.Clearbutton.Size = new global::System.Drawing.Size(106, 57);
			this.Clearbutton.TabIndex = 5;
			this.Clearbutton.Text = "清空結果欄";
			this.Clearbutton.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Clearbutton.UseVisualStyleBackColor = true;
			this.Clearbutton.Click += new global::System.EventHandler(this.Clearbutton_Click);
			this.button2.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button2.Location = new global::System.Drawing.Point(199, 9);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(261, 48);
			this.button2.TabIndex = 6;
			this.button2.Text = "陣列arr0711[]統計奇偶數的數量";
			this.button2.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.AutoSize = true;
			this.button3.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button3.Location = new global::System.Drawing.Point(16, 115);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(200, 33);
			this.button3.TabIndex = 7;
			this.button3.Text = "陣列arr0711[]最大/小值";
			this.button3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.AutoSize = true;
			this.button4.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button4.Location = new global::System.Drawing.Point(199, 76);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(261, 33);
			this.button4.TabIndex = 8;
			this.button4.Text = "陣列arr0711_Str[]最長的名字";
			this.button4.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.AutoSize = true;
			this.button5.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button5.Location = new global::System.Drawing.Point(466, 9);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(207, 33);
			this.button5.TabIndex = 9;
			this.button5.Text = "[10,10]二維陣列-邊1,內0";
			this.button5.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button6.AutoSize = true;
			this.button6.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button6.Location = new global::System.Drawing.Point(466, 52);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(207, 33);
			this.button6.TabIndex = 10;
			this.button6.Text = "[10,10]二維陣列-邊0,內1";
			this.button6.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.button7.AutoSize = true;
			this.button7.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button7.Location = new global::System.Drawing.Point(466, 91);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(189, 98);
			this.button7.TabIndex = 11;
			this.button7.Text = "[10,10]二維陣列\n101010\n010101\n...";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button8.AutoSize = true;
			this.button8.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button8.Location = new global::System.Drawing.Point(716, 9);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(129, 33);
			this.button8.TabIndex = 12;
			this.button8.Text = "Swap[int , int ]";
			this.button8.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button9.AutoSize = true;
			this.button9.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button9.Location = new global::System.Drawing.Point(716, 48);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(171, 33);
			this.button9.TabIndex = 13;
			this.button9.Text = "Sum(陣列arr0711[])";
			this.button9.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button10.AutoSize = true;
			this.button10.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button10.Location = new global::System.Drawing.Point(716, 87);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(171, 33);
			this.button10.TabIndex = 14;
			this.button10.Text = "Max(陣列arr0711[])";
			this.button10.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.button11.AutoSize = true;
			this.button11.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button11.Location = new global::System.Drawing.Point(716, 126);
			this.button11.Name = "button11";
			this.button11.Size = new global::System.Drawing.Size(171, 33);
			this.button11.TabIndex = 15;
			this.button11.Text = "Min(陣列arr0711[])";
			this.button11.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new global::System.EventHandler(this.button11_Click);
			this.button12.AutoSize = true;
			this.button12.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button12.Location = new global::System.Drawing.Point(16, 177);
			this.button12.Name = "button12";
			this.button12.Size = new global::System.Drawing.Size(369, 33);
			this.button12.TabIndex = 16;
			this.button12.Text = "陣列arr0711_Str[]xue \"C\" OR \"c\"的字樣有幾個";
			this.button12.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new global::System.EventHandler(this.button12_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new global::System.Drawing.Size(1047, 358);
			base.Controls.Add(this.button12);
			base.Controls.Add(this.button11);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.Clearbutton);
			base.Controls.Add(this.labelResult);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Name = "Myhomework_0711_Method";
			this.Text = "Myhomework_0711_Method";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000079 RID: 121
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label labelResult;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Button Clearbutton;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.Button button10;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.Button button11;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Button button12;
	}
}
