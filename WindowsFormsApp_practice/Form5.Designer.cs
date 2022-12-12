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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 495);
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
    }
}