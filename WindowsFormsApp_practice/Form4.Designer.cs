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
            this.label1 = new System.Windows.Forms.Label();
            this.localVariable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.classVar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_localVariable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.InstanceVar_btn = new System.Windows.Forms.Button();
            this.staticVar_btn = new System.Windows.Forms.Button();
            this.Instance_label = new System.Windows.Forms.Label();
            this.static_label = new System.Windows.Forms.Label();
            this.HelloFormCallStaticVar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(142, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 2;
            // 
            // localVariable
            // 
            this.localVariable.Location = new System.Drawing.Point(16, 43);
            this.localVariable.Name = "localVariable";
            this.localVariable.Size = new System.Drawing.Size(120, 47);
            this.localVariable.TabIndex = 3;
            this.localVariable.Text = "17_localVariable";
            this.localVariable.UseVisualStyleBackColor = true;
            this.localVariable.Click += new System.EventHandler(this.localVariable_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(142, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 2;
            // 
            // classVar
            // 
            this.classVar.Location = new System.Drawing.Point(16, 96);
            this.classVar.Name = "classVar";
            this.classVar.Size = new System.Drawing.Size(120, 47);
            this.classVar.TabIndex = 3;
            this.classVar.Text = "17_ClassVariable";
            this.classVar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_localVariable);
            this.panel1.Controls.Add(this.localVariable);
            this.panel1.Controls.Add(this.classVar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(230, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 162);
            this.panel1.TabIndex = 4;
            // 
            // label_localVariable
            // 
            this.label_localVariable.AutoSize = true;
            this.label_localVariable.Location = new System.Drawing.Point(22, 8);
            this.label_localVariable.Name = "label_localVariable";
            this.label_localVariable.Size = new System.Drawing.Size(82, 15);
            this.label_localVariable.TabIndex = 4;
            this.label_localVariable.Text = "localVariable";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.InstanceVar_btn);
            this.panel2.Controls.Add(this.staticVar_btn);
            this.panel2.Controls.Add(this.Instance_label);
            this.panel2.Controls.Add(this.static_label);
            this.panel2.Location = new System.Drawing.Point(230, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 162);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "InstanceAndStatic";
            // 
            // InstanceVar_btn
            // 
            this.InstanceVar_btn.Location = new System.Drawing.Point(16, 43);
            this.InstanceVar_btn.Name = "InstanceVar_btn";
            this.InstanceVar_btn.Size = new System.Drawing.Size(120, 47);
            this.InstanceVar_btn.TabIndex = 3;
            this.InstanceVar_btn.Text = "18_Instance";
            this.InstanceVar_btn.UseVisualStyleBackColor = true;
            this.InstanceVar_btn.Click += new System.EventHandler(this.InstanceVar_btn_Click);
            // 
            // staticVar_btn
            // 
            this.staticVar_btn.Location = new System.Drawing.Point(16, 96);
            this.staticVar_btn.Name = "staticVar_btn";
            this.staticVar_btn.Size = new System.Drawing.Size(120, 47);
            this.staticVar_btn.TabIndex = 3;
            this.staticVar_btn.Text = "18_static";
            this.staticVar_btn.UseVisualStyleBackColor = true;
            this.staticVar_btn.Click += new System.EventHandler(this.staticVar_btn_Click);
            // 
            // Instance_label
            // 
            this.Instance_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Instance_label.Location = new System.Drawing.Point(142, 67);
            this.Instance_label.Name = "Instance_label";
            this.Instance_label.Size = new System.Drawing.Size(148, 23);
            this.Instance_label.TabIndex = 2;
            // 
            // static_label
            // 
            this.static_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.static_label.Location = new System.Drawing.Point(142, 120);
            this.static_label.Name = "static_label";
            this.static_label.Size = new System.Drawing.Size(148, 23);
            this.static_label.TabIndex = 2;
            // 
            // HelloFormCallStaticVar
            // 
            this.HelloFormCallStaticVar.Location = new System.Drawing.Point(230, 377);
            this.HelloFormCallStaticVar.Name = "HelloFormCallStaticVar";
            this.HelloFormCallStaticVar.Size = new System.Drawing.Size(198, 41);
            this.HelloFormCallStaticVar.TabIndex = 6;
            this.HelloFormCallStaticVar.Text = "HelloFormCallStaticVar";
            this.HelloFormCallStaticVar.UseVisualStyleBackColor = true;
            this.HelloFormCallStaticVar.Click += new System.EventHandler(this.HelloFormCallStaticVar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloFormCallStaticVar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_acc_add_btn);
            this.Controls.Add(this.back_acc_disp);
            this.Controls.Add(this.front_acc_add_btn);
            this.Controls.Add(this.front_acc_disp);
            this.Controls.Add(this.btn_add1);
            this.Controls.Add(this.display4add);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display4add;
        private System.Windows.Forms.Button btn_add1;
        private System.Windows.Forms.Button front_acc_add_btn;
        private System.Windows.Forms.Label front_acc_disp;
        private System.Windows.Forms.Label back_acc_disp;
        private System.Windows.Forms.Button back_acc_add_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button localVariable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button classVar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_localVariable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InstanceVar_btn;
        private System.Windows.Forms.Button staticVar_btn;
        private System.Windows.Forms.Label Instance_label;
        private System.Windows.Forms.Label static_label;
        private System.Windows.Forms.Button HelloFormCallStaticVar;
    }
}