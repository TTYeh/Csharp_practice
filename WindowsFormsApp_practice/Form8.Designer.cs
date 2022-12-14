namespace WindowsFormsApp_practice
{
    partial class Form8
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labShowEmp = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "36_ArrList(泛用集合)_add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(78, 85);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(100, 25);
            this.txtBoxAge.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "年齡: ";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(78, 48);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(100, 25);
            this.txtBox_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.Location = new System.Drawing.Point(246, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "35_ArrList(泛用集合)(正確示範)_加入不同資料型態";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(36, 365);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(203, 52);
            this.btn_clear.TabIndex = 16;
            this.btn_clear.Text = "36_ArrList(泛用集合)_clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(36, 307);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(203, 52);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "36_ArrList(泛用集合)_remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "36_ArrList(泛用集合)_insert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxAge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBox_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 131);
            this.panel1.TabIndex = 13;
            // 
            // labShowEmp
            // 
            this.labShowEmp.AutoSize = true;
            this.labShowEmp.BackColor = System.Drawing.Color.YellowGreen;
            this.labShowEmp.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowEmp.ForeColor = System.Drawing.Color.Red;
            this.labShowEmp.Location = new System.Drawing.Point(455, 36);
            this.labShowEmp.Name = "labShowEmp";
            this.labShowEmp.Size = new System.Drawing.Size(99, 23);
            this.labShowEmp.TabIndex = 12;
            this.labShowEmp.Text = "員工:  ";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labShowEmp);
            this.Name = "Form8";
            this.Text = "Form8";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labShowEmp;
    }
}