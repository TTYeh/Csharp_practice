namespace MyHomework_張佑晨0705
{
	// Token: 0x02000002 RID: 2
	public partial class Myhomework_0705_POShp : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002580 File Offset: 0x00000780
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000025B8 File Offset: 0x000007B8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MyHomework_張佑晨0705.Myhomework_0705_POShp));
			this.label1 = new global::System.Windows.Forms.Label();
			this.Bear = new global::System.Windows.Forms.Button();
			this.Tequila = new global::System.Windows.Forms.Button();
			this.Whisky = new global::System.Windows.Forms.Button();
			this.Wine = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.ChList = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.Price = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.ClearList = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label1.Location = new global::System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(300, 369);
			this.label1.TabIndex = 0;
			this.label1.Text = "菜單 Menu";
			this.Bear.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("Bear.BackgroundImage");
			this.Bear.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.Bear.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Bear.ForeColor = global::System.Drawing.Color.Black;
			this.Bear.Location = new global::System.Drawing.Point(36, 100);
			this.Bear.Name = "Bear";
			this.Bear.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.Bear.Size = new global::System.Drawing.Size(120, 155);
			this.Bear.TabIndex = 1;
			this.Bear.Text = "啤酒\nBeer\nNT120";
			this.Bear.UseVisualStyleBackColor = true;
			this.Bear.Click += new global::System.EventHandler(this.Bear_Click);
			this.Tequila.BackColor = global::System.Drawing.Color.White;
			this.Tequila.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("Tequila.BackgroundImage");
			this.Tequila.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.Tequila.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Tequila.ForeColor = global::System.Drawing.Color.Black;
			this.Tequila.Location = new global::System.Drawing.Point(162, 100);
			this.Tequila.Name = "Tequila";
			this.Tequila.Size = new global::System.Drawing.Size(120, 155);
			this.Tequila.TabIndex = 2;
			this.Tequila.Text = "龍舌蘭\nTequila\nNT$180";
			this.Tequila.UseVisualStyleBackColor = false;
			this.Tequila.Click += new global::System.EventHandler(this.Tequila_Click);
			this.Whisky.BackColor = global::System.Drawing.Color.White;
			this.Whisky.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("Whisky.BackgroundImage");
			this.Whisky.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.Whisky.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Whisky.ForeColor = global::System.Drawing.Color.Black;
			this.Whisky.Location = new global::System.Drawing.Point(36, 265);
			this.Whisky.Name = "Whisky";
			this.Whisky.Size = new global::System.Drawing.Size(120, 155);
			this.Whisky.TabIndex = 3;
			this.Whisky.Text = "威士忌\nWhisky\nNT$350";
			this.Whisky.UseVisualStyleBackColor = false;
			this.Whisky.Click += new global::System.EventHandler(this.Whisky_Click);
			this.Wine.BackColor = global::System.Drawing.Color.White;
			this.Wine.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("Wine.BackgroundImage");
			this.Wine.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.Wine.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Wine.ForeColor = global::System.Drawing.Color.Black;
			this.Wine.Location = new global::System.Drawing.Point(162, 265);
			this.Wine.Name = "Wine";
			this.Wine.Size = new global::System.Drawing.Size(120, 155);
			this.Wine.TabIndex = 4;
			this.Wine.Text = "紅酒\nWine\nNT$320";
			this.Wine.UseVisualStyleBackColor = false;
			this.Wine.Click += new global::System.EventHandler(this.Wine_Click);
			this.label2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label2.Location = new global::System.Drawing.Point(631, 57);
			this.label2.Name = "label2";
			this.label2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new global::System.Drawing.Size(348, 369);
			this.label2.TabIndex = 5;
			this.label2.Text = "購物清單 List";
			this.ChList.BackColor = global::System.Drawing.Color.White;
			this.ChList.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.ChList.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.ChList.Location = new global::System.Drawing.Point(641, 85);
			this.ChList.Name = "ChList";
			this.ChList.Size = new global::System.Drawing.Size(329, 283);
			this.ChList.TabIndex = 6;
			this.ChList.Text = "尚未點餐";
			this.ChList.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.label3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label3.Location = new global::System.Drawing.Point(318, 57);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(307, 115);
			this.label3.TabIndex = 7;
			this.label3.Text = "總金額 Total Price";
			this.Price.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.Price.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.Price.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.Price.Location = new global::System.Drawing.Point(345, 100);
			this.Price.Name = "Price";
			this.Price.Size = new global::System.Drawing.Size(271, 46);
			this.Price.TabIndex = 8;
			this.Price.Text = "NT$ 0";
			this.Price.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.label4.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new global::System.Drawing.Font("微軟正黑體", 13.8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label4.Location = new global::System.Drawing.Point(318, 192);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(307, 142);
			this.label4.TabIndex = 9;
			this.label4.Text = "付款方式";
			this.button1.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button1.Location = new global::System.Drawing.Point(341, 242);
			this.button1.Name = "button1";
			this.button1.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new global::System.Drawing.Size(120, 49);
			this.button1.TabIndex = 10;
			this.button1.Text = "現金";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.button2.Location = new global::System.Drawing.Point(482, 242);
			this.button2.Name = "button2";
			this.button2.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.button2.Size = new global::System.Drawing.Size(120, 49);
			this.button2.TabIndex = 11;
			this.button2.Text = "信用卡";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label5.AutoSize = true;
			this.label5.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.label5.Location = new global::System.Drawing.Point(478, 300);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(140, 27);
			this.label5.TabIndex = 12;
			this.label5.Text = "信用卡享九折!";
			this.ClearList.Font = new global::System.Drawing.Font("微軟正黑體", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 136);
			this.ClearList.Location = new global::System.Drawing.Point(850, 371);
			this.ClearList.Name = "ClearList";
			this.ClearList.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.ClearList.Size = new global::System.Drawing.Size(120, 49);
			this.ClearList.TabIndex = 13;
			this.ClearList.Text = "清除清單";
			this.ClearList.UseVisualStyleBackColor = true;
			this.ClearList.Click += new global::System.EventHandler(this.ClearList_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(991, 553);
			base.Controls.Add(this.ClearList);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.Price);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.ChList);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Wine);
			base.Controls.Add(this.Whisky);
			base.Controls.Add(this.Tequila);
			base.Controls.Add(this.Bear);
			base.Controls.Add(this.label1);
			base.Name = "Form1";
			this.Text = "Bar POS";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button Bear;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button Tequila;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button Whisky;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button Wine;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label ChList;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label Price;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Button ClearList;
	}
}
