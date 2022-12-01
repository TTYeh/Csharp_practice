namespace WindowsFormsApp_practice
{
    partial class Form4
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
            this.display4add = new System.Windows.Forms.Label();
            this.btn_add1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display4add
            // 
            this.display4add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.display4add.Location = new System.Drawing.Point(44, 23);
            this.display4add.Name = "display4add";
            this.display4add.Size = new System.Drawing.Size(120, 23);
            this.display4add.TabIndex = 0;
            // 
            // btn_add1
            // 
            this.btn_add1.Location = new System.Drawing.Point(44, 49);
            this.btn_add1.Name = "btn_add1";
            this.btn_add1.Size = new System.Drawing.Size(120, 47);
            this.btn_add1.TabIndex = 1;
            this.btn_add1.Text = "14_累加+1";
            this.btn_add1.UseVisualStyleBackColor = true;
            this.btn_add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.display4add);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display4add;
        private System.Windows.Forms.Button btn_add1;
    }
}