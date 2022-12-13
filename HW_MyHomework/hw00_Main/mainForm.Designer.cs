using System.Windows.Forms;

namespace HW_MyHomework
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button18 = new System.Windows.Forms.Button();
            this.btn_Exam_guessNub = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_POS = new System.Windows.Forms.Button();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.btn_hello = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(58, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "c#作業";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 112);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScrollMargin = new System.Drawing.Size(100, 0);
            this.splitContainer1.Panel1.Controls.Add(this.button18);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Exam_guessNub);
            this.splitContainer1.Panel1.Controls.Add(this.button14);
            this.splitContainer1.Panel1.Controls.Add(this.button12);
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.button8);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button17);
            this.splitContainer1.Panel1.Controls.Add(this.button15);
            this.splitContainer1.Panel1.Controls.Add(this.button13);
            this.splitContainer1.Panel1.Controls.Add(this.button11);
            this.splitContainer1.Panel1.Controls.Add(this.button9);
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.btn_POS);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Loan);
            this.splitContainer1.Panel1.Controls.Add(this.btn_hello);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.BackgroundImage = global::HW_MyHomework.Properties.Resources.nasida;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint_1);
            this.splitContainer1.Size = new System.Drawing.Size(1229, 597);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 1;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(252, 375);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(155, 40);
            this.button18.TabIndex = 0;
            this.button18.Text = "button1";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // btn_Exam_guessNub
            // 
            this.btn_Exam_guessNub.Location = new System.Drawing.Point(252, 329);
            this.btn_Exam_guessNub.Name = "btn_Exam_guessNub";
            this.btn_Exam_guessNub.Size = new System.Drawing.Size(155, 40);
            this.btn_Exam_guessNub.TabIndex = 0;
            this.btn_Exam_guessNub.Text = "GuessNumber";
            this.btn_Exam_guessNub.UseVisualStyleBackColor = true;
            this.btn_Exam_guessNub.Click += new System.EventHandler(this.btn_Exam_guessNub_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(252, 283);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(155, 40);
            this.button14.TabIndex = 0;
            this.button14.Text = "button1";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(252, 237);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(155, 40);
            this.button12.TabIndex = 0;
            this.button12.Text = "button1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(252, 191);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 40);
            this.button10.TabIndex = 0;
            this.button10.Text = "button1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(252, 145);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(155, 40);
            this.button8.TabIndex = 0;
            this.button8.Text = "button1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(252, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "button1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(252, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 375);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(155, 40);
            this.button17.TabIndex = 0;
            this.button17.Text = "button1";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(12, 329);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(155, 40);
            this.button15.TabIndex = 0;
            this.button15.Text = "button1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(12, 283);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(155, 40);
            this.button13.TabIndex = 0;
            this.button13.Text = "button1";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 237);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(155, 40);
            this.button11.TabIndex = 0;
            this.button11.Text = "button1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(12, 191);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(155, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "button1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 145);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_POS
            // 
            this.btn_POS.Location = new System.Drawing.Point(12, 99);
            this.btn_POS.Name = "btn_POS";
            this.btn_POS.Size = new System.Drawing.Size(155, 40);
            this.btn_POS.TabIndex = 0;
            this.btn_POS.Text = "03_POS";
            this.btn_POS.UseVisualStyleBackColor = true;
            // 
            // btn_Loan
            // 
            this.btn_Loan.Location = new System.Drawing.Point(12, 53);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(155, 40);
            this.btn_Loan.TabIndex = 0;
            this.btn_Loan.Text = "02_Loan";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(12, 7);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(155, 40);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "01_Hello";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 700);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button btn_Exam_guessNub;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_POS;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.Button btn_hello;
    }
}

