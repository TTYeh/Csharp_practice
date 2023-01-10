namespace MyHomework_張佑晨
{
	// Token: 0x02000006 RID: 6
	public partial class Myhomework_0709_StudentsGrade : global::System.Windows.Forms.Form
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000626C File Offset: 0x0000446C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000062A4 File Offset: 0x000044A4
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
			this.Random = new global::System.Windows.Forms.Button();
			this.summury = new global::System.Windows.Forms.Button();
			this.Reset = new global::System.Windows.Forms.Button();
			this.Random20 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.label5 = new global::System.Windows.Forms.Label();
			this.GradeShowLabel = new global::System.Windows.Forms.Label();
			this.Chibox = new global::System.Windows.Forms.TextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.Statisticslabel = new global::System.Windows.Forms.Label();
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
			this.Random.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Random.Location = new global::System.Drawing.Point(24, 264);
			this.Random.Name = "Random";
			this.Random.Size = new global::System.Drawing.Size(151, 34);
			this.Random.TabIndex = 17;
			this.Random.Text = "隨機儲存資料";
			this.Random.UseVisualStyleBackColor = true;
			this.Random.Click += new global::System.EventHandler(this.RandomSave);
			this.summury.Enabled = false;
			this.summury.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.summury.Location = new global::System.Drawing.Point(24, 304);
			this.summury.Name = "summury";
			this.summury.Size = new global::System.Drawing.Size(151, 34);
			this.summury.TabIndex = 18;
			this.summury.Text = "各科統計";
			this.summury.UseVisualStyleBackColor = true;
			this.summury.Click += new global::System.EventHandler(this.button2_Click);
			this.Reset.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Reset.Location = new global::System.Drawing.Point(25, 393);
			this.Reset.Name = "Reset";
			this.Reset.Size = new global::System.Drawing.Size(151, 34);
			this.Reset.TabIndex = 19;
			this.Reset.Text = "重設所有資料";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new global::System.EventHandler(this.button3_Click);
			this.Random20.Font = new global::System.Drawing.Font("微軟正黑體", 10.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Random20.Location = new global::System.Drawing.Point(25, 433);
			this.Random20.Name = "Random20";
			this.Random20.Size = new global::System.Drawing.Size(151, 34);
			this.Random20.TabIndex = 20;
			this.Random20.Text = "隨機加入20筆";
			this.Random20.UseVisualStyleBackColor = true;
			this.Random20.Click += new global::System.EventHandler(this.button4_Click);
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
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(766, 495);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.Random20);
			base.Controls.Add(this.Reset);
			base.Controls.Add(this.summury);
			base.Controls.Add(this.Random);
			base.Controls.Add(this.Save);
			base.Controls.Add(this.Mathbox);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.Enbox);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Chibox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Namebox);
			base.Controls.Add(this.label1);
			base.Name = "Myhomework_0709_StudentsGrade";
			this.Text = "Myhomework_0709";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000048 RID: 72
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.TextBox Mathbox;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.TextBox Enbox;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.TextBox Namebox;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Button Save;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.Button Random;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Button summury;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Button Reset;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Button Random20;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Label GradeShowLabel;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TextBox Chibox;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label Statisticslabel;
	}
}
