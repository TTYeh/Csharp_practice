namespace Hw_detNet
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_99Multiple = new System.Windows.Forms.Button();
            this.btn_judgeTime = new System.Windows.Forms.Button();
            this.btn_judgePrime = new System.Windows.Forms.Button();
            this.btn_letterChange = new System.Windows.Forms.Button();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_LeftStar = new System.Windows.Forms.Button();
            this.btnRightStar = new System.Windows.Forms.Button();
            this.btnMidStar = new System.Windows.Forms.Button();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMidStar);
            this.panel1.Controls.Add(this.btnRightStar);
            this.panel1.Controls.Add(this.btn_LeftStar);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.inputNum);
            this.panel1.Controls.Add(this.btn_letterChange);
            this.panel1.Controls.Add(this.btn_judgePrime);
            this.panel1.Controls.Add(this.btn_judgeTime);
            this.panel1.Controls.Add(this.btn_99Multiple);
            this.panel1.Location = new System.Drawing.Point(37, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 491);
            this.panel1.TabIndex = 0;
            // 
            // btn_99Multiple
            // 
            this.btn_99Multiple.Location = new System.Drawing.Point(13, 26);
            this.btn_99Multiple.Name = "btn_99Multiple";
            this.btn_99Multiple.Size = new System.Drawing.Size(149, 65);
            this.btn_99Multiple.TabIndex = 1;
            this.btn_99Multiple.Text = "hw1_99乘法表";
            this.btn_99Multiple.UseVisualStyleBackColor = true;
            this.btn_99Multiple.Click += new System.EventHandler(this.btn_99Multiple_Click);
            // 
            // btn_judgeTime
            // 
            this.btn_judgeTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_judgeTime.Location = new System.Drawing.Point(13, 97);
            this.btn_judgeTime.Name = "btn_judgeTime";
            this.btn_judgeTime.Size = new System.Drawing.Size(149, 65);
            this.btn_judgeTime.TabIndex = 2;
            this.btn_judgeTime.Text = "hw2_判斷營業時間";
            this.btn_judgeTime.UseVisualStyleBackColor = true;
            this.btn_judgeTime.Click += new System.EventHandler(this.btn_judgeTime_Click);
            // 
            // btn_judgePrime
            // 
            this.btn_judgePrime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_judgePrime.Location = new System.Drawing.Point(13, 168);
            this.btn_judgePrime.Name = "btn_judgePrime";
            this.btn_judgePrime.Size = new System.Drawing.Size(149, 65);
            this.btn_judgePrime.TabIndex = 3;
            this.btn_judgePrime.Text = "hw3_判斷是否為質數";
            this.btn_judgePrime.UseVisualStyleBackColor = true;
            this.btn_judgePrime.Click += new System.EventHandler(this.btn_judgePrime_Click);
            // 
            // btn_letterChange
            // 
            this.btn_letterChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_letterChange.Location = new System.Drawing.Point(13, 239);
            this.btn_letterChange.Name = "btn_letterChange";
            this.btn_letterChange.Size = new System.Drawing.Size(149, 65);
            this.btn_letterChange.TabIndex = 4;
            this.btn_letterChange.Text = "hw4_字母大小寫轉換";
            this.btn_letterChange.UseVisualStyleBackColor = true;
            this.btn_letterChange.Click += new System.EventHandler(this.btn_letterChange_Click);
            // 
            // inputNum
            // 
            this.inputNum.Location = new System.Drawing.Point(168, 208);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(100, 25);
            this.inputNum.TabIndex = 5;
            this.inputNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 25);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_LeftStar
            // 
            this.btn_LeftStar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_LeftStar.Location = new System.Drawing.Point(13, 310);
            this.btn_LeftStar.Name = "btn_LeftStar";
            this.btn_LeftStar.Size = new System.Drawing.Size(149, 65);
            this.btn_LeftStar.TabIndex = 7;
            this.btn_LeftStar.Text = "hw5_左三角星星";
            this.btn_LeftStar.UseVisualStyleBackColor = true;
            // 
            // btnRightStar
            // 
            this.btnRightStar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRightStar.Location = new System.Drawing.Point(13, 381);
            this.btnRightStar.Name = "btnRightStar";
            this.btnRightStar.Size = new System.Drawing.Size(149, 65);
            this.btnRightStar.TabIndex = 8;
            this.btnRightStar.Text = "hw5_右三角星星";
            this.btnRightStar.UseVisualStyleBackColor = true;
            // 
            // btnMidStar
            // 
            this.btnMidStar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMidStar.Location = new System.Drawing.Point(168, 381);
            this.btnMidStar.Name = "btnMidStar";
            this.btnMidStar.Size = new System.Drawing.Size(149, 65);
            this.btnMidStar.TabIndex = 9;
            this.btnMidStar.Text = "hw5_正三角星星";
            this.btnMidStar.UseVisualStyleBackColor = true;
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(467, 16);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxShow.Size = new System.Drawing.Size(624, 491);
            this.textBoxShow.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 533);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_judgeTime;
        private System.Windows.Forms.Button btn_99Multiple;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.Button btn_letterChange;
        private System.Windows.Forms.Button btn_judgePrime;
        private System.Windows.Forms.Button btnMidStar;
        private System.Windows.Forms.Button btnRightStar;
        private System.Windows.Forms.Button btn_LeftStar;
        private System.Windows.Forms.TextBox textBoxShow;
    }
}

