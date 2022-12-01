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
            this.front_acc_add_btn = new System.Windows.Forms.Button();
            this.front_acc_disp = new System.Windows.Forms.Label();
            this.back_acc_disp = new System.Windows.Forms.Label();
            this.back_acc_add_btn = new System.Windows.Forms.Button();
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
            // front_acc_add_btn
            // 
            this.front_acc_add_btn.Location = new System.Drawing.Point(44, 152);
            this.front_acc_add_btn.Name = "front_acc_add_btn";
            this.front_acc_add_btn.Size = new System.Drawing.Size(120, 47);
            this.front_acc_add_btn.TabIndex = 3;
            this.front_acc_add_btn.Text = "15_前置遞增";
            this.front_acc_add_btn.UseVisualStyleBackColor = true;
            this.front_acc_add_btn.Click += new System.EventHandler(this.front_acc_add_btn_Click);
            // 
            // front_acc_disp
            // 
            this.front_acc_disp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.front_acc_disp.Location = new System.Drawing.Point(44, 126);
            this.front_acc_disp.Name = "front_acc_disp";
            this.front_acc_disp.Size = new System.Drawing.Size(120, 23);
            this.front_acc_disp.TabIndex = 2;
            // 
            // back_acc_disp
            // 
            this.back_acc_disp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.back_acc_disp.Location = new System.Drawing.Point(44, 236);
            this.back_acc_disp.Name = "back_acc_disp";
            this.back_acc_disp.Size = new System.Drawing.Size(120, 23);
            this.back_acc_disp.TabIndex = 2;
            // 
            // back_acc_add_btn
            // 
            this.back_acc_add_btn.Location = new System.Drawing.Point(44, 262);
            this.back_acc_add_btn.Name = "back_acc_add_btn";
            this.back_acc_add_btn.Size = new System.Drawing.Size(120, 47);
            this.back_acc_add_btn.TabIndex = 3;
            this.back_acc_add_btn.Text = "16_後置遞增";
            this.back_acc_add_btn.UseVisualStyleBackColor = true;
            this.back_acc_add_btn.Click += new System.EventHandler(this.back_acc_add_btn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_acc_add_btn);
            this.Controls.Add(this.back_acc_disp);
            this.Controls.Add(this.front_acc_add_btn);
            this.Controls.Add(this.front_acc_disp);
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
        private System.Windows.Forms.Button front_acc_add_btn;
        private System.Windows.Forms.Label front_acc_disp;
        private System.Windows.Forms.Label back_acc_disp;
        private System.Windows.Forms.Button back_acc_add_btn;
    }
}