namespace WindowsFormsApp_practice
{
    partial class Form2
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
            this.openHelloForm = new System.Windows.Forms.Button();
            this.method_area = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openHelloForm
            // 
            this.openHelloForm.Location = new System.Drawing.Point(526, 137);
            this.openHelloForm.Name = "openHelloForm";
            this.openHelloForm.Size = new System.Drawing.Size(75, 23);
            this.openHelloForm.TabIndex = 0;
            this.openHelloForm.Text = "openHelloForm";
            this.openHelloForm.UseVisualStyleBackColor = true;
            this.openHelloForm.Click += new System.EventHandler(this.openHelloForm_Click);
            // 
            // method_area
            // 
            this.method_area.Location = new System.Drawing.Point(526, 199);
            this.method_area.Name = "method_area";
            this.method_area.Size = new System.Drawing.Size(208, 51);
            this.method_area.TabIndex = 1;
            this.method_area.Text = "call function(method)";
            this.method_area.UseVisualStyleBackColor = true;
            this.method_area.Click += new System.EventHandler(this.method_area_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.method_area);
            this.Controls.Add(this.openHelloForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openHelloForm;
        private System.Windows.Forms.Button method_area;
    }
}