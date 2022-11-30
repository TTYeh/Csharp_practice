namespace WindowsFormsApp_practice
{
    partial class Form3
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
            this.btn_register_event = new System.Windows.Forms.Button();
            this.TestEvent_btn = new System.Windows.Forms.Button();
            this.btn_register02 = new System.Windows.Forms.Button();
            this.cancel_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_register_event
            // 
            this.btn_register_event.Location = new System.Drawing.Point(113, 41);
            this.btn_register_event.Name = "btn_register_event";
            this.btn_register_event.Size = new System.Drawing.Size(252, 66);
            this.btn_register_event.TabIndex = 0;
            this.btn_register_event.Text = "09_Register_Click_btn_event";
            this.btn_register_event.UseVisualStyleBackColor = true;
            this.btn_register_event.Click += new System.EventHandler(this.btn_register_event_Click);
            // 
            // TestEvent_btn
            // 
            this.TestEvent_btn.Location = new System.Drawing.Point(113, 134);
            this.TestEvent_btn.Name = "TestEvent_btn";
            this.TestEvent_btn.Size = new System.Drawing.Size(252, 66);
            this.TestEvent_btn.TabIndex = 1;
            this.TestEvent_btn.Text = "09_A_Click_btn";
            this.TestEvent_btn.UseVisualStyleBackColor = true;
            // 
            // btn_register02
            // 
            this.btn_register02.Location = new System.Drawing.Point(113, 218);
            this.btn_register02.Name = "btn_register02";
            this.btn_register02.Size = new System.Drawing.Size(252, 66);
            this.btn_register02.TabIndex = 1;
            this.btn_register02.Text = "09_B_Click_btn";
            this.btn_register02.UseVisualStyleBackColor = true;
            // 
            // cancel_register
            // 
            this.cancel_register.Location = new System.Drawing.Point(113, 315);
            this.cancel_register.Name = "cancel_register";
            this.cancel_register.Size = new System.Drawing.Size(252, 66);
            this.cancel_register.TabIndex = 2;
            this.cancel_register.Text = "09_Cancel_Register_event";
            this.cancel_register.UseVisualStyleBackColor = true;
            this.cancel_register.Click += new System.EventHandler(this.cancel_register_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel_register);
            this.Controls.Add(this.btn_register02);
            this.Controls.Add(this.TestEvent_btn);
            this.Controls.Add(this.btn_register_event);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_register_event;
        private System.Windows.Forms.Button TestEvent_btn;
        private System.Windows.Forms.Button btn_register02;
        private System.Windows.Forms.Button cancel_register;
    }
}