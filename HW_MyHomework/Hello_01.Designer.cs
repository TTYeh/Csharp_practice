using System.Drawing;

namespace HW_MyHomework
{
    partial class Hello_01
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
            this.btn_hi = new System.Windows.Forms.Button();
            this.btn_hello = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputNamelabel = new System.Windows.Forms.Label();
            this.inputEngNamelebal = new System.Windows.Forms.Label();
            this.inputEngName = new System.Windows.Forms.TextBox();
            this.inputSexlabel = new System.Windows.Forms.Label();
            this.inputSex = new System.Windows.Forms.TextBox();
            this.inputStarsignlabel = new System.Windows.Forms.Label();
            this.inputStarsign = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_hi
            // 
            this.btn_hi.Location = new System.Drawing.Point(192, 306);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.Size = new System.Drawing.Size(141, 63);
            this.btn_hi.TabIndex = 0;
            this.btn_hi.Text = "say Hi!";
            this.btn_hi.UseVisualStyleBackColor = true;
            this.btn_hi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(35, 306);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(141, 63);
            this.btn_hello.TabIndex = 1;
            this.btn_hello.Text = "say Hello";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputName
            // 
            this.inputName.AllowDrop = true;
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.inputName.BackColor = System.Drawing.SystemColors.Window;
            this.inputName.Location = new System.Drawing.Point(192, 47);
            this.inputName.Multiline = true;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(140, 40);
            this.inputName.TabIndex = 2;
            this.inputName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // inputNamelabel
            // 
            this.inputNamelabel.AllowDrop = true;
            this.inputNamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputNamelabel.AutoEllipsis = true;
            this.inputNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.inputNamelabel.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputNamelabel.Location = new System.Drawing.Point(48, 47);
            this.inputNamelabel.Name = "inputNamelabel";
            this.inputNamelabel.Size = new System.Drawing.Size(140, 40);
            this.inputNamelabel.TabIndex = 3;
            this.inputNamelabel.Text = "姓名:";
            this.inputNamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputEngNamelebal
            // 
            this.inputEngNamelebal.AllowDrop = true;
            this.inputEngNamelebal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEngNamelebal.AutoEllipsis = true;
            this.inputEngNamelebal.BackColor = System.Drawing.Color.Transparent;
            this.inputEngNamelebal.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputEngNamelebal.Location = new System.Drawing.Point(48, 106);
            this.inputEngNamelebal.Name = "inputEngNamelebal";
            this.inputEngNamelebal.Size = new System.Drawing.Size(140, 40);
            this.inputEngNamelebal.TabIndex = 5;
            this.inputEngNamelebal.Text = "Name:";
            this.inputEngNamelebal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputEngNamelebal.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputEngName
            // 
            this.inputEngName.AllowDrop = true;
            this.inputEngName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEngName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.inputEngName.BackColor = System.Drawing.SystemColors.Window;
            this.inputEngName.Location = new System.Drawing.Point(192, 106);
            this.inputEngName.Multiline = true;
            this.inputEngName.Name = "inputEngName";
            this.inputEngName.Size = new System.Drawing.Size(140, 40);
            this.inputEngName.TabIndex = 4;
            this.inputEngName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // inputSexlabel
            // 
            this.inputSexlabel.AllowDrop = true;
            this.inputSexlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSexlabel.AutoEllipsis = true;
            this.inputSexlabel.BackColor = System.Drawing.Color.Transparent;
            this.inputSexlabel.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputSexlabel.Location = new System.Drawing.Point(48, 166);
            this.inputSexlabel.Name = "inputSexlabel";
            this.inputSexlabel.Size = new System.Drawing.Size(140, 40);
            this.inputSexlabel.TabIndex = 7;
            this.inputSexlabel.Text = "性別:";
            this.inputSexlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputSexlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // inputSex
            // 
            this.inputSex.AllowDrop = true;
            this.inputSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.inputSex.BackColor = System.Drawing.SystemColors.Window;
            this.inputSex.Location = new System.Drawing.Point(192, 166);
            this.inputSex.Multiline = true;
            this.inputSex.Name = "inputSex";
            this.inputSex.Size = new System.Drawing.Size(140, 40);
            this.inputSex.TabIndex = 6;
            this.inputSex.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // inputStarsignlabel
            // 
            this.inputStarsignlabel.AllowDrop = true;
            this.inputStarsignlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputStarsignlabel.AutoEllipsis = true;
            this.inputStarsignlabel.BackColor = System.Drawing.Color.Transparent;
            this.inputStarsignlabel.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.inputStarsignlabel.Location = new System.Drawing.Point(48, 223);
            this.inputStarsignlabel.Name = "inputStarsignlabel";
            this.inputStarsignlabel.Size = new System.Drawing.Size(140, 40);
            this.inputStarsignlabel.TabIndex = 9;
            this.inputStarsignlabel.Text = "星座:";
            this.inputStarsignlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inputStarsignlabel.Click += new System.EventHandler(this.inputStarsignlabel_Click);
            // 
            // inputStarsign
            // 
            this.inputStarsign.AllowDrop = true;
            this.inputStarsign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inputStarsign.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.inputStarsign.BackColor = System.Drawing.SystemColors.Window;
            this.inputStarsign.Location = new System.Drawing.Point(192, 223);
            this.inputStarsign.Multiline = true;
            this.inputStarsign.Name = "inputStarsign";
            this.inputStarsign.Size = new System.Drawing.Size(140, 40);
            this.inputStarsign.TabIndex = 8;
            // 
            // Hello_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HW_MyHomework.Properties.Resources.pimon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputStarsignlabel);
            this.Controls.Add(this.inputStarsign);
            this.Controls.Add(this.inputSexlabel);
            this.Controls.Add(this.inputSex);
            this.Controls.Add(this.inputEngNamelebal);
            this.Controls.Add(this.inputEngName);
            this.Controls.Add(this.inputNamelabel);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.btn_hello);
            this.Controls.Add(this.btn_hi);
            this.Name = "Hello_01";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hello_01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hi;
        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label inputNamelabel;
        private System.Windows.Forms.Label inputEngNamelebal;
        private System.Windows.Forms.TextBox inputEngName;
        private System.Windows.Forms.Label inputSexlabel;
        private System.Windows.Forms.TextBox inputSex;
        private System.Windows.Forms.Label inputStarsignlabel;
        private System.Windows.Forms.TextBox inputStarsign;

        private void SetMyButtonIcon()
        {
            // TODO  https://stackoverflow.com/questions/11483655/icon-inside-of-button
            // Assign an image to the button.
            btn_hi.Image = Image.FromFile("C:\\Graphics\\My.ico");
            string CurPath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            // C: \\Users\\User\Desktop\cSharp_practice\project\lab_Csharp_practice\source\image_hw
            // Align the image and text on the button.
            btn_hi.ImageAlign = ContentAlignment.MiddleRight;
            btn_hi.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
}