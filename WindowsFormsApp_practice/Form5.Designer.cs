namespace WindowsFormsApp_practice
{
    partial class Form5
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
            this.btn_refAsParas = new System.Windows.Forms.Button();
            this.btn_ref22 = new System.Windows.Forms.Button();
            this.btn_refOut = new System.Windows.Forms.Button();
            this.btn_paras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnValid = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnValidConst = new System.Windows.Forms.Button();
            this.btnValidEnum = new System.Windows.Forms.Button();
            this.btnEnumCase = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.inputProductName = new System.Windows.Forms.TextBox();
            this.inputPrice = new System.Windows.Forms.TextBox();
            this.labelshow = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refAsParas
            // 
            this.btn_refAsParas.Location = new System.Drawing.Point(41, 42);
            this.btn_refAsParas.Name = "btn_refAsParas";
            this.btn_refAsParas.Size = new System.Drawing.Size(116, 63);
            this.btn_refAsParas.TabIndex = 0;
            this.btn_refAsParas.Text = "21_refAsParas";
            this.btn_refAsParas.UseVisualStyleBackColor = true;
            this.btn_refAsParas.Click += new System.EventHandler(this.btn_callVal_Click);
            // 
            // btn_ref22
            // 
            this.btn_ref22.Location = new System.Drawing.Point(41, 111);
            this.btn_ref22.Name = "btn_ref22";
            this.btn_ref22.Size = new System.Drawing.Size(116, 63);
            this.btn_ref22.TabIndex = 1;
            this.btn_ref22.Text = "22_ref as ByRef";
            this.btn_ref22.UseVisualStyleBackColor = true;
            this.btn_ref22.Click += new System.EventHandler(this.btn_ref22_Click);
            // 
            // btn_refOut
            // 
            this.btn_refOut.Location = new System.Drawing.Point(41, 180);
            this.btn_refOut.Name = "btn_refOut";
            this.btn_refOut.Size = new System.Drawing.Size(116, 63);
            this.btn_refOut.TabIndex = 2;
            this.btn_refOut.Text = "23_ref as out";
            this.btn_refOut.UseVisualStyleBackColor = true;
            this.btn_refOut.Click += new System.EventHandler(this.btn_refOut_Click);
            // 
            // btn_paras
            // 
            this.btn_paras.Location = new System.Drawing.Point(41, 249);
            this.btn_paras.Name = "btn_paras";
            this.btn_paras.Size = new System.Drawing.Size(116, 63);
            this.btn_paras.TabIndex = 3;
            this.btn_paras.Text = "24_paras";
            this.btn_paras.UseVisualStyleBackColor = true;
            this.btn_paras.Click += new System.EventHandler(this.btn_paras_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "25_enum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(258, 42);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(116, 63);
            this.btnValid.TabIndex = 5;
            this.btnValid.Text = "26_驗證身分";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(405, 42);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(116, 63);
            this.btnProduct.TabIndex = 6;
            this.btnProduct.Text = "26_Pruduct";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnValidConst
            // 
            this.btnValidConst.Location = new System.Drawing.Point(258, 111);
            this.btnValidConst.Name = "btnValidConst";
            this.btnValidConst.Size = new System.Drawing.Size(169, 63);
            this.btnValidConst.TabIndex = 7;
            this.btnValidConst.Text = "26_驗證身分_const";
            this.btnValidConst.UseVisualStyleBackColor = true;
            this.btnValidConst.Click += new System.EventHandler(this.btnValidConst_Click);
            // 
            // btnValidEnum
            // 
            this.btnValidEnum.Location = new System.Drawing.Point(258, 180);
            this.btnValidEnum.Name = "btnValidEnum";
            this.btnValidEnum.Size = new System.Drawing.Size(169, 63);
            this.btnValidEnum.TabIndex = 8;
            this.btnValidEnum.Text = "26_驗證身分_enum";
            this.btnValidEnum.UseVisualStyleBackColor = true;
            this.btnValidEnum.Click += new System.EventHandler(this.btnValidEnum_Click);
            // 
            // btnEnumCase
            // 
            this.btnEnumCase.Location = new System.Drawing.Point(258, 249);
            this.btnEnumCase.Name = "btnEnumCase";
            this.btnEnumCase.Size = new System.Drawing.Size(169, 63);
            this.btnEnumCase.TabIndex = 9;
            this.btnEnumCase.Text = "26_驗證身分_enum+case";
            this.btnEnumCase.UseVisualStyleBackColor = true;
            this.btnEnumCase.Click += new System.EventHandler(this.btnEnumCase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "產品:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "單價:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "27.addProduct";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputProductName
            // 
            this.inputProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.inputProductName.Location = new System.Drawing.Point(104, 21);
            this.inputProductName.Multiline = true;
            this.inputProductName.Name = "inputProductName";
            this.inputProductName.Size = new System.Drawing.Size(162, 38);
            this.inputProductName.TabIndex = 13;
            // 
            // inputPrice
            // 
            this.inputPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.inputPrice.Location = new System.Drawing.Point(104, 65);
            this.inputPrice.Multiline = true;
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(162, 38);
            this.inputPrice.TabIndex = 14;
            // 
            // labelshow
            // 
            this.labelshow.Location = new System.Drawing.Point(27, 200);
            this.labelshow.Name = "labelshow";
            this.labelshow.Size = new System.Drawing.Size(409, 172);
            this.labelshow.TabIndex = 15;
            this.labelshow.Text = "顯示產品字串";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 60);
            this.button3.TabIndex = 16;
            this.button3.Text = "27.addProductUtility";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.labelshow);
            this.panel1.Controls.Add(this.inputPrice);
            this.panel1.Controls.Add(this.inputProductName);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(565, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 392);
            this.panel1.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 60);
            this.button4.TabIndex = 17;
            this.button4.Text = "27.addProductUtility2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(316, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 60);
            this.button5.TabIndex = 18;
            this.button5.Text = "27.addProductUtility2_tryParse";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnumCase);
            this.Controls.Add(this.btnValidEnum);
            this.Controls.Add(this.btnValidConst);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_paras);
            this.Controls.Add(this.btn_refOut);
            this.Controls.Add(this.btn_ref22);
            this.Controls.Add(this.btn_refAsParas);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_refAsParas;
        private System.Windows.Forms.Button btn_ref22;
        private System.Windows.Forms.Button btn_refOut;
        private System.Windows.Forms.Button btn_paras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnValidConst;
        private System.Windows.Forms.Button btnValidEnum;
        private System.Windows.Forms.Button btnEnumCase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputProductName;
        private System.Windows.Forms.TextBox inputPrice;
        private System.Windows.Forms.Label labelshow;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}