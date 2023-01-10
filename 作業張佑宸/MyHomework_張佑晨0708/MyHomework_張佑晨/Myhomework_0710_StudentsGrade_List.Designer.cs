namespace MyHomework_張佑晨
{
	// Token: 0x02000007 RID: 7
	public partial class Myhomework_0710_StudentsGrade_List : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00007BD4 File Offset: 0x00005DD4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007C0C File Offset: 0x00005E0C
		private void InitializeComponent()
		{
			this.Mathbox = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.Enbox = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.Namebox = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.Save = new global::System.Windows.Forms.Button();
			this.InsertList = new global::System.Windows.Forms.Button();
			this.summury = new global::System.Windows.Forms.Button();
			this.Reset = new global::System.Windows.Forms.Button();
			this.RemoveList = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.GradeShowLabel = new global::System.Windows.Forms.Label();
			this.Chibox = new global::System.Windows.Forms.TextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.Statisticslabel = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.SerchList = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.Mathbox.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Mathbox.Location = new global::System.Drawing.Point(90, 178);
			this.Mathbox.Name = "Mathbox";
			this.Mathbox.Size = new global::System.Drawing.Size(85, 34);
			this.Mathbox.TabIndex = 15;
			this.Mathbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label4.Location = new global::System.Drawing.Point(12, 181);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(72, 25);
			this.label4.TabIndex = 14;
			this.label4.Text = "數學：";
			this.Enbox.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Enbox.Location = new global::System.Drawing.Point(90, 118);
			this.Enbox.Name = "Enbox";
			this.Enbox.Size = new global::System.Drawing.Size(85, 34);
			this.Enbox.TabIndex = 13;
			this.Enbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label3.Location = new global::System.Drawing.Point(12, 121);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(72, 25);
			this.label3.TabIndex = 12;
			this.label3.Text = "英文：";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label2.Location = new global::System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(72, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "國文：";
			this.Namebox.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Namebox.Location = new global::System.Drawing.Point(90, 6);
			this.Namebox.Name = "Namebox";
			this.Namebox.Size = new global::System.Drawing.Size(85, 34);
			this.Namebox.TabIndex = 9;
			this.Namebox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(72, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "姓名：";
			this.Save.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Save.Location = new global::System.Drawing.Point(24, 224);
			this.Save.Name = "Save";
			this.Save.Size = new global::System.Drawing.Size(151, 34);
			this.Save.TabIndex = 16;
			this.Save.Text = "加入學生資料";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new global::System.EventHandler(this.Save_Click);
			this.InsertList.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.InsertList.Location = new global::System.Drawing.Point(24, 264);
			this.InsertList.Name = "InsertList";
			this.InsertList.Size = new global::System.Drawing.Size(151, 34);
			this.InsertList.TabIndex = 17;
			this.InsertList.Text = "插入儲存資料";
			this.InsertList.UseVisualStyleBackColor = true;
			this.InsertList.Click += new global::System.EventHandler(this.InsertSave);
			this.summury.Enabled = false;
			this.summury.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.summury.Location = new global::System.Drawing.Point(591, 489);
			this.summury.Name = "summury";
			this.summury.Size = new global::System.Drawing.Size(151, 34);
			this.summury.TabIndex = 18;
			this.summury.Text = "各科統計";
			this.summury.UseVisualStyleBackColor = true;
			this.summury.Click += new global::System.EventHandler(this.button2_Click);
			this.Reset.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Reset.Location = new global::System.Drawing.Point(24, 344);
			this.Reset.Name = "Reset";
			this.Reset.Size = new global::System.Drawing.Size(151, 34);
			this.Reset.TabIndex = 19;
			this.Reset.Text = "清除所有資料";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new global::System.EventHandler(this.button3_Click);
			this.RemoveList.Enabled = false;
			this.RemoveList.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.RemoveList.Location = new global::System.Drawing.Point(24, 304);
			this.RemoveList.Name = "RemoveList";
			this.RemoveList.Size = new global::System.Drawing.Size(151, 34);
			this.RemoveList.TabIndex = 20;
			this.RemoveList.Text = "移除資料";
			this.RemoveList.UseVisualStyleBackColor = true;
			this.RemoveList.Click += new global::System.EventHandler(this.button4_Click);
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.GradeShowLabel);
			this.panel1.Location = new global::System.Drawing.Point(194, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(548, 318);
			this.panel1.TabIndex = 21;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("標楷體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label5.Location = new global::System.Drawing.Point(3, 3);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(494, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "姓名     國文  英文  數學  總分   平均   最低     最高";
			this.GradeShowLabel.AutoSize = true;
			this.GradeShowLabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.GradeShowLabel.Font = new global::System.Drawing.Font("標楷體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.GradeShowLabel.Location = new global::System.Drawing.Point(3, 29);
			this.GradeShowLabel.Name = "GradeShowLabel";
			this.GradeShowLabel.Size = new global::System.Drawing.Size(2, 19);
			this.GradeShowLabel.TabIndex = 0;
			this.Chibox.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Chibox.Location = new global::System.Drawing.Point(90, 61);
			this.Chibox.Name = "Chibox";
			this.Chibox.Size = new global::System.Drawing.Size(85, 34);
			this.Chibox.TabIndex = 11;
			this.Chibox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.Statisticslabel);
			this.panel2.Location = new global::System.Drawing.Point(194, 336);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(548, 147);
			this.panel2.TabIndex = 22;
			this.Statisticslabel.AutoSize = true;
			this.Statisticslabel.Font = new global::System.Drawing.Font("標楷體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Statisticslabel.Location = new global::System.Drawing.Point(0, 3);
			this.Statisticslabel.Name = "Statisticslabel";
			this.Statisticslabel.Size = new global::System.Drawing.Size(0, 17);
			this.Statisticslabel.TabIndex = 2;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label6.Location = new global::System.Drawing.Point(2, 381);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(163, 22);
			this.label6.TabIndex = 23;
			this.label6.Text = "搜尋國文成績範圍：";
			this.textBox1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBox1.Location = new global::System.Drawing.Point(17, 415);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(54, 34);
			this.textBox1.TabIndex = 24;
			this.textBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label7.Location = new global::System.Drawing.Point(77, 421);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(27, 22);
			this.label7.TabIndex = 25;
			this.label7.Text = "－";
			this.textBox2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.textBox2.Location = new global::System.Drawing.Point(110, 415);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(54, 34);
			this.textBox2.TabIndex = 26;
			this.textBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.SerchList.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.SerchList.Location = new global::System.Drawing.Point(24, 469);
			this.SerchList.Name = "SerchList";
			this.SerchList.Size = new global::System.Drawing.Size(151, 34);
			this.SerchList.TabIndex = 27;
			this.SerchList.Text = "SERCH";
			this.SerchList.UseVisualStyleBackColor = true;
			this.SerchList.Click += new global::System.EventHandler(this.SerchList_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(766, 544);
			base.Controls.Add(this.SerchList);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.RemoveList);
			base.Controls.Add(this.Reset);
			base.Controls.Add(this.summury);
			base.Controls.Add(this.InsertList);
			base.Controls.Add(this.Save);
			base.Controls.Add(this.Mathbox);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.Enbox);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Chibox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Namebox);
			base.Controls.Add(this.label1);
			base.Name = "Myhomework_0710_StudentsGrade_List";
			this.Text = "Myhomework_0709";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.TextBox Mathbox;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.TextBox Enbox;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.TextBox Namebox;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.Button Save;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Button InsertList;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Button summury;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Button Reset;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Button RemoveList;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label GradeShowLabel;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.TextBox Chibox;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label Statisticslabel;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Button SerchList;
	}
}
