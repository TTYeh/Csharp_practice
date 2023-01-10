namespace MyHomework_張佑晨
{
	// Token: 0x0200000D RID: 13
	public partial class Student_StructForm_0708 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.Namebox = new global::System.Windows.Forms.TextBox();
			this.Chibox = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.Enbox = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.Mathbox = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.save = new global::System.Windows.Forms.Button();
			this.show = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.MaxMinlabel = new global::System.Windows.Forms.Label();
			this.Gralabel = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(86, 66);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(85, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "姓名：";
			this.Namebox.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Namebox.Location = new global::System.Drawing.Point(165, 63);
			this.Namebox.Name = "Namebox";
			this.Namebox.Size = new global::System.Drawing.Size(151, 38);
			this.Namebox.TabIndex = 1;
			this.Namebox.Text = "0";
			this.Namebox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Chibox.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Chibox.Location = new global::System.Drawing.Point(165, 118);
			this.Chibox.Name = "Chibox";
			this.Chibox.Size = new global::System.Drawing.Size(151, 38);
			this.Chibox.TabIndex = 3;
			this.Chibox.Text = "0";
			this.Chibox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label2.Location = new global::System.Drawing.Point(86, 121);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(85, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "國文：";
			this.Enbox.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Enbox.Location = new global::System.Drawing.Point(165, 175);
			this.Enbox.Name = "Enbox";
			this.Enbox.Size = new global::System.Drawing.Size(151, 38);
			this.Enbox.TabIndex = 5;
			this.Enbox.Text = "0";
			this.Enbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label3.Location = new global::System.Drawing.Point(86, 178);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(85, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "英文：";
			this.Mathbox.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Mathbox.Location = new global::System.Drawing.Point(165, 235);
			this.Mathbox.Name = "Mathbox";
			this.Mathbox.Size = new global::System.Drawing.Size(151, 38);
			this.Mathbox.TabIndex = 7;
			this.Mathbox.Text = "0";
			this.Mathbox.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label4.Location = new global::System.Drawing.Point(86, 238);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(85, 30);
			this.label4.TabIndex = 6;
			this.label4.Text = "數學：";
			this.save.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.save.Location = new global::System.Drawing.Point(64, 329);
			this.save.Name = "save";
			this.save.Size = new global::System.Drawing.Size(136, 51);
			this.save.TabIndex = 8;
			this.save.Text = "儲存";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new global::System.EventHandler(this.save_Click);
			this.show.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.show.Location = new global::System.Drawing.Point(221, 329);
			this.show.Name = "show";
			this.show.Size = new global::System.Drawing.Size(154, 51);
			this.show.TabIndex = 9;
			this.show.Text = "顯示儲存內容";
			this.show.UseVisualStyleBackColor = true;
			this.show.Click += new global::System.EventHandler(this.show_Click);
			this.button2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button2.Location = new global::System.Drawing.Point(539, 368);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(203, 51);
			this.button2.TabIndex = 10;
			this.button2.Text = "最高分/最低分科目";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.groupBox1.Controls.Add(this.MaxMinlabel);
			this.groupBox1.Controls.Add(this.Gralabel);
			this.groupBox1.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.groupBox1.Location = new global::System.Drawing.Point(421, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(333, 350);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "成績";
			this.MaxMinlabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.MaxMinlabel.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.MaxMinlabel.Location = new global::System.Drawing.Point(6, 226);
			this.MaxMinlabel.Name = "MaxMinlabel";
			this.MaxMinlabel.Size = new global::System.Drawing.Size(321, 121);
			this.MaxMinlabel.TabIndex = 1;
			this.Gralabel.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Gralabel.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Gralabel.Location = new global::System.Drawing.Point(6, 34);
			this.Gralabel.Name = "Gralabel";
			this.Gralabel.Size = new global::System.Drawing.Size(321, 189);
			this.Gralabel.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.show);
			base.Controls.Add(this.save);
			base.Controls.Add(this.Mathbox);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.Enbox);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.Chibox);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Namebox);
			base.Controls.Add(this.label1);
			base.Name = "Student_StructForm";
			this.Text = "Student_StructForm";
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000CE RID: 206
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.TextBox Namebox;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.TextBox Chibox;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.TextBox Enbox;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.TextBox Mathbox;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Button save;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.Button show;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.Label Gralabel;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.Label MaxMinlabel;
	}
}
