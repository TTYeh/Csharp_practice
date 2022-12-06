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
            this.setName1 = new System.Windows.Forms.Button();
            this.getProperty = new System.Windows.Forms.Button();
            this.setBound = new System.Windows.Forms.Button();
            this.msgboxApp = new System.Windows.Forms.Button();
            this.label_icontest = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // setName1
            // 
            this.setName1.Location = new System.Drawing.Point(422, 41);
            this.setName1.Name = "setName1";
            this.setName1.Size = new System.Drawing.Size(251, 66);
            this.setName1.TabIndex = 3;
            this.setName1.TabStop = false;
            this.setName1.Text = "10_setProperty_name_1";
            this.setName1.UseVisualStyleBackColor = true;
            this.setName1.Click += new System.EventHandler(this.setName1_Click);
            // 
            // getProperty
            // 
            this.getProperty.Location = new System.Drawing.Point(422, 134);
            this.getProperty.Name = "getProperty";
            this.getProperty.Size = new System.Drawing.Size(251, 66);
            this.getProperty.TabIndex = 4;
            this.getProperty.Text = "11_getProperty";
            this.getProperty.UseMnemonic = false;
            this.getProperty.UseVisualStyleBackColor = true;
            this.getProperty.Click += new System.EventHandler(this.getProperty_Click);
            // 
            // setBound
            // 
            this.setBound.Location = new System.Drawing.Point(422, 218);
            this.setBound.Name = "setBound";
            this.setBound.Size = new System.Drawing.Size(251, 66);
            this.setBound.TabIndex = 5;
            this.setBound.Text = "12_setBound";
            this.setBound.UseVisualStyleBackColor = true;
            this.setBound.Click += new System.EventHandler(this.setBound_Click);
            // 
            // msgboxApp
            // 
            this.msgboxApp.Location = new System.Drawing.Point(422, 315);
            this.msgboxApp.Name = "msgboxApp";
            this.msgboxApp.Size = new System.Drawing.Size(251, 66);
            this.msgboxApp.TabIndex = 6;
            this.msgboxApp.Text = "13_msgbox";
            this.msgboxApp.UseVisualStyleBackColor = true;
            this.msgboxApp.Click += new System.EventHandler(this.msgboxApp_Click);
            // 
            // label_icontest
            // 
            this.label_icontest.Location = new System.Drawing.Point(730, 41);
            this.label_icontest.Name = "label_icontest";
            this.label_icontest.Size = new System.Drawing.Size(215, 66);
            this.label_icontest.TabIndex = 7;
            this.label_icontest.Text = "label1";
            this.label_icontest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Location = new System.Drawing.Point(733, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(212, 122);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "ReadOnly\r\nddddd\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_icontest);
            this.Controls.Add(this.msgboxApp);
            this.Controls.Add(this.setBound);
            this.Controls.Add(this.getProperty);
            this.Controls.Add(this.setName1);
            this.Controls.Add(this.cancel_register);
            this.Controls.Add(this.btn_register02);
            this.Controls.Add(this.TestEvent_btn);
            this.Controls.Add(this.btn_register_event);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register_event;
        private System.Windows.Forms.Button TestEvent_btn;
        private System.Windows.Forms.Button btn_register02;
        private System.Windows.Forms.Button cancel_register;
        private System.Windows.Forms.Button setName1;
        private System.Windows.Forms.Button getProperty;
        private System.Windows.Forms.Button setBound;
        private System.Windows.Forms.Button msgboxApp;
        private System.Windows.Forms.Label label_icontest;
        private System.Windows.Forms.TextBox textBox1;
    }
}