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
            this.SuspendLayout();
            // 
            // btn_refAsParas
            // 
            this.btn_refAsParas.Location = new System.Drawing.Point(75, 49);
            this.btn_refAsParas.Name = "btn_refAsParas";
            this.btn_refAsParas.Size = new System.Drawing.Size(116, 63);
            this.btn_refAsParas.TabIndex = 0;
            this.btn_refAsParas.Text = "21_refAsParas";
            this.btn_refAsParas.UseVisualStyleBackColor = true;
            this.btn_refAsParas.Click += new System.EventHandler(this.btn_callVal_Click);
            // 
            // btn_ref22
            // 
            this.btn_ref22.Location = new System.Drawing.Point(75, 135);
            this.btn_ref22.Name = "btn_ref22";
            this.btn_ref22.Size = new System.Drawing.Size(116, 63);
            this.btn_ref22.TabIndex = 1;
            this.btn_ref22.Text = "22_ref as ByRef";
            this.btn_ref22.UseVisualStyleBackColor = true;
            this.btn_ref22.Click += new System.EventHandler(this.btn_ref22_Click);
            // 
            // btn_refOut
            // 
            this.btn_refOut.Location = new System.Drawing.Point(75, 216);
            this.btn_refOut.Name = "btn_refOut";
            this.btn_refOut.Size = new System.Drawing.Size(116, 63);
            this.btn_refOut.TabIndex = 2;
            this.btn_refOut.Text = "23_ref as out";
            this.btn_refOut.UseVisualStyleBackColor = true;
            this.btn_refOut.Click += new System.EventHandler(this.btn_refOut_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 495);
            this.Controls.Add(this.btn_refOut);
            this.Controls.Add(this.btn_ref22);
            this.Controls.Add(this.btn_refAsParas);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_refAsParas;
        private System.Windows.Forms.Button btn_ref22;
        private System.Windows.Forms.Button btn_refOut;
    }
}