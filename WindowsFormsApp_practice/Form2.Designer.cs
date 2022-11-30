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
            this.returnMethod = new System.Windows.Forms.Button();
            this.btn05_callOtherClassMethod = new System.Windows.Forms.Button();
            this.encapsulation_callMethod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openHelloForm
            // 
            this.openHelloForm.Location = new System.Drawing.Point(30, 36);
            this.openHelloForm.Name = "openHelloForm";
            this.openHelloForm.Size = new System.Drawing.Size(184, 23);
            this.openHelloForm.TabIndex = 0;
            this.openHelloForm.Text = "02_openHelloForm";
            this.openHelloForm.UseVisualStyleBackColor = true;
            this.openHelloForm.Click += new System.EventHandler(this.openHelloForm_Click);
            // 
            // method_area
            // 
            this.method_area.Location = new System.Drawing.Point(30, 98);
            this.method_area.Name = "method_area";
            this.method_area.Size = new System.Drawing.Size(184, 45);
            this.method_area.TabIndex = 1;
            this.method_area.Text = "03_call function(method)";
            this.method_area.UseVisualStyleBackColor = true;
            this.method_area.Click += new System.EventHandler(this.method_area_Click);
            // 
            // returnMethod
            // 
            this.returnMethod.Location = new System.Drawing.Point(30, 174);
            this.returnMethod.Name = "returnMethod";
            this.returnMethod.Size = new System.Drawing.Size(184, 40);
            this.returnMethod.TabIndex = 3;
            this.returnMethod.Text = "04_returnMethod";
            this.returnMethod.UseVisualStyleBackColor = true;
            this.returnMethod.Click += new System.EventHandler(this.returnMethod_Click);
            // 
            // btn05_callOtherClassMethod
            // 
            this.btn05_callOtherClassMethod.Location = new System.Drawing.Point(30, 234);
            this.btn05_callOtherClassMethod.Name = "btn05_callOtherClassMethod";
            this.btn05_callOtherClassMethod.Size = new System.Drawing.Size(184, 40);
            this.btn05_callOtherClassMethod.TabIndex = 4;
            this.btn05_callOtherClassMethod.TabStop = false;
            this.btn05_callOtherClassMethod.Text = "05_call other class method";
            this.btn05_callOtherClassMethod.UseVisualStyleBackColor = true;
            this.btn05_callOtherClassMethod.Click += new System.EventHandler(this.btn05_callOtherClassMethod_Click);
            // 
            // encapsulation_callMethod
            // 
            this.encapsulation_callMethod.Location = new System.Drawing.Point(30, 280);
            this.encapsulation_callMethod.Name = "encapsulation_callMethod";
            this.encapsulation_callMethod.Size = new System.Drawing.Size(184, 40);
            this.encapsulation_callMethod.TabIndex = 4;
            this.encapsulation_callMethod.TabStop = false;
            this.encapsulation_callMethod.Text = "封裝encapsulation";
            this.encapsulation_callMethod.UseVisualStyleBackColor = true;
            this.encapsulation_callMethod.Click += new System.EventHandler(this.btn05_callOtherClassMethod_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.encapsulation_callMethod);
            this.Controls.Add(this.btn05_callOtherClassMethod);
            this.Controls.Add(this.returnMethod);
            this.Controls.Add(this.method_area);
            this.Controls.Add(this.openHelloForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openHelloForm;
        private System.Windows.Forms.Button method_area;
        private System.Windows.Forms.Button returnMethod;
        private System.Windows.Forms.Button btn05_callOtherClassMethod;
        private System.Windows.Forms.Button encapsulation_callMethod;
    }
}