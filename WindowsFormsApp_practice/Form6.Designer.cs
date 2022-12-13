namespace WindowsFormsApp_practice
{
    partial class Form6
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
            this.btn_logic = new System.Windows.Forms.Button();
            this.btn28TripleLogic = new System.Windows.Forms.Button();
            this.btn29_1 = new System.Windows.Forms.Button();
            this.btn29_2 = new System.Windows.Forms.Button();
            this.textScore = new System.Windows.Forms.TextBox();
            this.labelGrade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logic
            // 
            this.btn_logic.Location = new System.Drawing.Point(90, 72);
            this.btn_logic.Name = "btn_logic";
            this.btn_logic.Size = new System.Drawing.Size(115, 53);
            this.btn_logic.TabIndex = 0;
            this.btn_logic.Text = "27_邏輯運算子";
            this.btn_logic.UseVisualStyleBackColor = true;
            // 
            // btn28TripleLogic
            // 
            this.btn28TripleLogic.Location = new System.Drawing.Point(90, 131);
            this.btn28TripleLogic.Name = "btn28TripleLogic";
            this.btn28TripleLogic.Size = new System.Drawing.Size(115, 53);
            this.btn28TripleLogic.TabIndex = 1;
            this.btn28TripleLogic.Text = "28三元運算子";
            this.btn28TripleLogic.UseVisualStyleBackColor = true;
            // 
            // btn29_1
            // 
            this.btn29_1.Location = new System.Drawing.Point(90, 190);
            this.btn29_1.Name = "btn29_1";
            this.btn29_1.Size = new System.Drawing.Size(115, 53);
            this.btn29_1.TabIndex = 2;
            this.btn29_1.Text = "29CaseStruct-1";
            this.btn29_1.UseVisualStyleBackColor = true;
            this.btn29_1.Click += new System.EventHandler(this.btn29_1_Click);
            // 
            // btn29_2
            // 
            this.btn29_2.Location = new System.Drawing.Point(90, 249);
            this.btn29_2.Name = "btn29_2";
            this.btn29_2.Size = new System.Drawing.Size(115, 53);
            this.btn29_2.TabIndex = 3;
            this.btn29_2.Text = "29CaseStruct-2";
            this.btn29_2.UseVisualStyleBackColor = true;
            this.btn29_2.Click += new System.EventHandler(this.btn29_2_Click);
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(212, 190);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(100, 25);
            this.textScore.TabIndex = 4;
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(212, 227);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(41, 15);
            this.labelGrade.TabIndex = 5;
            this.labelGrade.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "30While";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.btn29_2);
            this.Controls.Add(this.btn29_1);
            this.Controls.Add(this.btn28TripleLogic);
            this.Controls.Add(this.btn_logic);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logic;
        private System.Windows.Forms.Button btn28TripleLogic;
        private System.Windows.Forms.Button btn29_1;
        private System.Windows.Forms.Button btn29_2;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Button button1;
    }
}