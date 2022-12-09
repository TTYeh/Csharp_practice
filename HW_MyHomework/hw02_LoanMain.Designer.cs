namespace HW_MyHomework
{
    partial class hw02_Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_monthPay = new System.Windows.Forms.Button();
            this.btn_totalPay = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input_loan_money = new System.Windows.Forms.TextBox();
            this.input_loanYear = new System.Windows.Forms.TextBox();
            this.input_interstRate = new System.Windows.Forms.TextBox();
            this.input_downPayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_monthPay
            // 
            this.btn_monthPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_monthPay.Location = new System.Drawing.Point(108, 292);
            this.btn_monthPay.Name = "btn_monthPay";
            this.btn_monthPay.Size = new System.Drawing.Size(149, 74);
            this.btn_monthPay.TabIndex = 0;
            this.btn_monthPay.Text = "PMT(月付)";
            this.btn_monthPay.UseVisualStyleBackColor = true;
            this.btn_monthPay.Click += new System.EventHandler(this.btn_monthPay_Click);
            // 
            // btn_totalPay
            // 
            this.btn_totalPay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_totalPay.Location = new System.Drawing.Point(281, 292);
            this.btn_totalPay.Name = "btn_totalPay";
            this.btn_totalPay.Size = new System.Drawing.Size(149, 74);
            this.btn_totalPay.TabIndex = 1;
            this.btn_totalPay.Text = "總付款";
            this.btn_totalPay.UseVisualStyleBackColor = true;
            this.btn_totalPay.Click += new System.EventHandler(this.btn_totalPay_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(514, 292);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(149, 74);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(108, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(108, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(108, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "頭期款";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(108, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 44);
            this.label4.TabIndex = 5;
            this.label4.Text = "利率(%)";
            // 
            // input_loan_money
            // 
            this.input_loan_money.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_loan_money.Location = new System.Drawing.Point(281, 22);
            this.input_loan_money.Multiline = true;
            this.input_loan_money.Name = "input_loan_money";
            this.input_loan_money.Size = new System.Drawing.Size(149, 44);
            this.input_loan_money.TabIndex = 7;
            this.input_loan_money.Text = "1000000";
            // 
            // input_loanYear
            // 
            this.input_loanYear.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_loanYear.Location = new System.Drawing.Point(281, 81);
            this.input_loanYear.Multiline = true;
            this.input_loanYear.Name = "input_loanYear";
            this.input_loanYear.Size = new System.Drawing.Size(149, 44);
            this.input_loanYear.TabIndex = 8;
            this.input_loanYear.Text = "1";
            // 
            // input_interstRate
            // 
            this.input_interstRate.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_interstRate.Location = new System.Drawing.Point(281, 142);
            this.input_interstRate.Multiline = true;
            this.input_interstRate.Name = "input_interstRate";
            this.input_interstRate.Size = new System.Drawing.Size(149, 44);
            this.input_interstRate.TabIndex = 9;
            this.input_interstRate.Text = "2";
            // 
            // input_downPayment
            // 
            this.input_downPayment.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input_downPayment.Location = new System.Drawing.Point(281, 203);
            this.input_downPayment.Multiline = true;
            this.input_downPayment.Name = "input_downPayment";
            this.input_downPayment.Size = new System.Drawing.Size(149, 44);
            this.input_downPayment.TabIndex = 10;
            this.input_downPayment.Text = "0";
            // 
            // hw02_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_downPayment);
            this.Controls.Add(this.input_interstRate);
            this.Controls.Add(this.input_loanYear);
            this.Controls.Add(this.input_loan_money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_totalPay);
            this.Controls.Add(this.btn_monthPay);
            this.Name = "hw02_Loan";
            this.Text = "貸款金額計算";
            this.Load += new System.EventHandler(this.hw02_Loan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_monthPay;
        private System.Windows.Forms.Button btn_totalPay;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input_loan_money;
        private System.Windows.Forms.TextBox input_loanYear;
        private System.Windows.Forms.TextBox input_interstRate;
        private System.Windows.Forms.TextBox input_downPayment;
    }
}