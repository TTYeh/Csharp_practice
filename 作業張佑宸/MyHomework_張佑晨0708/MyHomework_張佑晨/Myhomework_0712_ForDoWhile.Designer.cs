namespace MyHomework_張佑晨
{
	// Token: 0x02000009 RID: 9
	public partial class Myhomework_0712_ForDoWhile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000B224 File Offset: 0x00009424
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000B25C File Offset: 0x0000945C
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
			this.button13 = new global::System.Windows.Forms.Button();
			this.textBoxFrom = new global::System.Windows.Forms.TextBox();
			this.textBoxTo = new global::System.Windows.Forms.TextBox();
			this.textBoxStep = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.button14 = new global::System.Windows.Forms.Button();
			this.button15 = new global::System.Windows.Forms.Button();
			this.button16 = new global::System.Windows.Forms.Button();
			this.textBoxRows = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.button17 = new global::System.Windows.Forms.Button();
			this.button18 = new global::System.Windows.Forms.Button();
			this.button19 = new global::System.Windows.Forms.Button();
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
			this.label2.Location = new global::System.Drawing.Point(12, 263);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(102, 35);
			this.label2.TabIndex = 3;
			this.label2.Text = "Result:";
			this.labelResult.AutoSize = true;
			this.labelResult.BackColor = global::System.Drawing.Color.LemonChiffon;
			this.labelResult.Font = new global::System.Drawing.Font("Consolas", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelResult.ForeColor = global::System.Drawing.Color.Gray;
			this.labelResult.Location = new global::System.Drawing.Point(24, 303);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new global::System.Drawing.Size(54, 23);
			this.labelResult.TabIndex = 4;
			this.labelResult.Text = "結果";
			this.Clearbutton.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Clearbutton.Location = new global::System.Drawing.Point(172, 216);
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
			this.button13.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button13.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button13.Location = new global::System.Drawing.Point(695, 234);
			this.button13.Name = "button13";
			this.button13.Size = new global::System.Drawing.Size(129, 57);
			this.button13.TabIndex = 17;
			this.button13.Text = "九九乘法表";
			this.button13.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += new global::System.EventHandler(this.button13_Click);
			this.textBoxFrom.Font = new global::System.Drawing.Font("新細明體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBoxFrom.Location = new global::System.Drawing.Point(466, 195);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new global::System.Drawing.Size(82, 28);
			this.textBoxFrom.TabIndex = 18;
			this.textBoxTo.Font = new global::System.Drawing.Font("新細明體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBoxTo.Location = new global::System.Drawing.Point(466, 229);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new global::System.Drawing.Size(82, 28);
			this.textBoxTo.TabIndex = 19;
			this.textBoxStep.Font = new global::System.Drawing.Font("新細明體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBoxStep.Location = new global::System.Drawing.Point(466, 263);
			this.textBoxStep.Name = "textBoxStep";
			this.textBoxStep.Size = new global::System.Drawing.Size(82, 28);
			this.textBoxStep.TabIndex = 20;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label3.Location = new global::System.Drawing.Point(404, 201);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(56, 22);
			this.label3.TabIndex = 21;
			this.label3.Text = "From:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label4.Location = new global::System.Drawing.Point(425, 232);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(35, 22);
			this.label4.TabIndex = 22;
			this.label4.Text = "To:";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label5.Location = new global::System.Drawing.Point(409, 263);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(51, 22);
			this.label5.TabIndex = 23;
			this.label5.Text = "Step:";
			this.button14.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button14.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button14.Location = new global::System.Drawing.Point(554, 195);
			this.button14.Name = "button14";
			this.button14.Size = new global::System.Drawing.Size(69, 28);
			this.button14.TabIndex = 24;
			this.button14.Text = "for";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += new global::System.EventHandler(this.button14_Click);
			this.button15.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button15.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button15.Location = new global::System.Drawing.Point(554, 229);
			this.button15.Name = "button15";
			this.button15.Size = new global::System.Drawing.Size(69, 28);
			this.button15.TabIndex = 25;
			this.button15.Text = "while";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += new global::System.EventHandler(this.button15_Click);
			this.button16.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button16.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button16.Location = new global::System.Drawing.Point(554, 260);
			this.button16.Name = "button16";
			this.button16.Size = new global::System.Drawing.Size(69, 28);
			this.button16.TabIndex = 26;
			this.button16.Text = "do";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += new global::System.EventHandler(this.button16_Click);
			this.textBoxRows.Font = new global::System.Drawing.Font("新細明體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBoxRows.Location = new global::System.Drawing.Point(724, 165);
			this.textBoxRows.Name = "textBoxRows";
			this.textBoxRows.Size = new global::System.Drawing.Size(82, 28);
			this.textBoxRows.TabIndex = 27;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label6.Location = new global::System.Drawing.Point(661, 167);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(57, 22);
			this.label6.TabIndex = 28;
			this.label6.Text = "Rows:";
			this.button17.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button17.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button17.Location = new global::System.Drawing.Point(695, 198);
			this.button17.Name = "button17";
			this.button17.Size = new global::System.Drawing.Size(129, 29);
			this.button17.TabIndex = 29;
			this.button17.Text = "直角聖誕樹";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += new global::System.EventHandler(this.button17_Click);
			this.button18.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button18.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button18.Location = new global::System.Drawing.Point(831, 167);
			this.button18.Name = "button18";
			this.button18.Size = new global::System.Drawing.Size(170, 29);
			this.button18.TabIndex = 30;
			this.button18.Text = "100的二進位是?";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += new global::System.EventHandler(this.button18_Click);
			this.button19.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.button19.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button19.Location = new global::System.Drawing.Point(831, 202);
			this.button19.Name = "button19";
			this.button19.Size = new global::System.Drawing.Size(170, 29);
			this.button19.TabIndex = 31;
			this.button19.Text = "樂透int[]號碼不重複";
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += new global::System.EventHandler(this.button19_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new global::System.Drawing.Size(1109, 641);
			base.Controls.Add(this.button19);
			base.Controls.Add(this.button18);
			base.Controls.Add(this.button17);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.textBoxRows);
			base.Controls.Add(this.button16);
			base.Controls.Add(this.button15);
			base.Controls.Add(this.button14);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBoxStep);
			base.Controls.Add(this.textBoxTo);
			base.Controls.Add(this.textBoxFrom);
			base.Controls.Add(this.button13);
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
			base.Name = "Myhomework_0712_ForDoWhile";
			this.Text = "Myhomework_0711_Method";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400008F RID: 143
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.Label labelResult;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.Button Clearbutton;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.Button button6;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.Button button8;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.Button button10;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Button button11;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.Button button12;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.Button button13;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.TextBox textBoxFrom;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.TextBox textBoxTo;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.TextBox textBoxStep;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Button button14;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Button button15;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.Button button16;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.TextBox textBoxRows;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Button button17;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Button button18;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Button button19;
	}
}
