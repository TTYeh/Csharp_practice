namespace MyHomework_張佑晨
{
	// Token: 0x02000004 RID: 4
	public partial class Myhomework_0703_Hello : global::System.Windows.Forms.Form
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00003E0C File Offset: 0x0000200C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003E44 File Offset: 0x00002044
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MyHomework_張佑晨.Myhomework_0703_Hello));
			this.LBChiName = new global::System.Windows.Forms.Label();
			this.LBEnName = new global::System.Windows.Forms.Label();
			this.LBsex = new global::System.Windows.Forms.Label();
			this.LBcons = new global::System.Windows.Forms.Label();
			this.ChiName = new global::System.Windows.Forms.TextBox();
			this.sex = new global::System.Windows.Forms.TextBox();
			this.cons = new global::System.Windows.Forms.TextBox();
			this.Hello = new global::System.Windows.Forms.Button();
			this.Hi = new global::System.Windows.Forms.Button();
			this.EnName = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.LBChiName.AutoSize = true;
			this.LBChiName.BackColor = global::System.Drawing.Color.Transparent;
			this.LBChiName.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.LBChiName.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.LBChiName.Location = new global::System.Drawing.Point(58, 86);
			this.LBChiName.Name = "LBChiName";
			this.LBChiName.Size = new global::System.Drawing.Size(99, 35);
			this.LBChiName.TabIndex = 0;
			this.LBChiName.Text = "姓名：";
			this.LBEnName.AutoSize = true;
			this.LBEnName.BackColor = global::System.Drawing.Color.Transparent;
			this.LBEnName.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.LBEnName.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.LBEnName.Location = new global::System.Drawing.Point(58, 157);
			this.LBEnName.Name = "LBEnName";
			this.LBEnName.Size = new global::System.Drawing.Size(202, 35);
			this.LBEnName.TabIndex = 1;
			this.LBEnName.Text = "English Name:";
			this.LBsex.AutoSize = true;
			this.LBsex.BackColor = global::System.Drawing.Color.Transparent;
			this.LBsex.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.LBsex.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.LBsex.Location = new global::System.Drawing.Point(58, 232);
			this.LBsex.Name = "LBsex";
			this.LBsex.Size = new global::System.Drawing.Size(99, 35);
			this.LBsex.TabIndex = 2;
			this.LBsex.Text = "性別：";
			this.LBcons.AutoSize = true;
			this.LBcons.BackColor = global::System.Drawing.Color.Transparent;
			this.LBcons.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.LBcons.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.LBcons.Location = new global::System.Drawing.Point(58, 299);
			this.LBcons.Name = "LBcons";
			this.LBcons.Size = new global::System.Drawing.Size(99, 35);
			this.LBcons.TabIndex = 3;
			this.LBcons.Text = "星座：";
			this.ChiName.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.ChiName.Location = new global::System.Drawing.Point(263, 83);
			this.ChiName.Name = "ChiName";
			this.ChiName.Size = new global::System.Drawing.Size(186, 43);
			this.ChiName.TabIndex = 4;
			this.sex.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.sex.Location = new global::System.Drawing.Point(263, 224);
			this.sex.Name = "sex";
			this.sex.Size = new global::System.Drawing.Size(186, 43);
			this.sex.TabIndex = 7;
			this.cons.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.cons.Location = new global::System.Drawing.Point(263, 291);
			this.cons.Name = "cons";
			this.cons.Size = new global::System.Drawing.Size(186, 43);
			this.cons.TabIndex = 8;
			this.Hello.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("Hello.BackgroundImage");
			this.Hello.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.Hello.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Hello.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Hello.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Hello.Location = new global::System.Drawing.Point(64, 388);
			this.Hello.Name = "Hello";
			this.Hello.Size = new global::System.Drawing.Size(196, 47);
			this.Hello.TabIndex = 9;
			this.Hello.Text = "Say HELLO!";
			this.Hello.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Hello.UseVisualStyleBackColor = true;
			this.Hello.Click += new global::System.EventHandler(this.Hello_Click);
			this.Hi.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("Hi.BackgroundImage");
			this.Hi.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.Hi.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Hi.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Hi.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Hi.ImageAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.Hi.Location = new global::System.Drawing.Point(292, 388);
			this.Hi.Name = "Hi";
			this.Hi.Size = new global::System.Drawing.Size(167, 47);
			this.Hi.TabIndex = 10;
			this.Hi.Text = "Say HI!";
			this.Hi.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.Hi.UseVisualStyleBackColor = true;
			this.Hi.Click += new global::System.EventHandler(this.Hi_Click);
			this.EnName.Font = new global::System.Drawing.Font("微軟正黑體", 16.2f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.EnName.Location = new global::System.Drawing.Point(263, 157);
			this.EnName.Name = "EnName";
			this.EnName.Size = new global::System.Drawing.Size(186, 43);
			this.EnName.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(849, 532);
			base.Controls.Add(this.Hi);
			base.Controls.Add(this.Hello);
			base.Controls.Add(this.cons);
			base.Controls.Add(this.sex);
			base.Controls.Add(this.EnName);
			base.Controls.Add(this.ChiName);
			base.Controls.Add(this.LBcons);
			base.Controls.Add(this.LBsex);
			base.Controls.Add(this.LBEnName);
			base.Controls.Add(this.LBChiName);
			base.Name = "Form1";
			this.Text = "你好! C#";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002D RID: 45
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Label LBChiName;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label LBEnName;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label LBsex;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label LBcons;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.TextBox ChiName;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.TextBox sex;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.TextBox cons;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button Hello;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Button Hi;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.TextBox EnName;
	}
}
