﻿namespace Galois_fields
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.radioButtonApp = new System.Windows.Forms.RadioButton();
            this.radioButtonSub = new System.Windows.Forms.RadioButton();
            this.radioButtonMul = new System.Windows.Forms.RadioButton();
            this.radioButtonDiv = new System.Windows.Forms.RadioButton();
            this.buttonResult = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelA1 = new System.Windows.Forms.Label();
            this.labelA2 = new System.Windows.Forms.Label();
            this.labelA3 = new System.Windows.Forms.Label();
            this.labelA4 = new System.Windows.Forms.Label();
            this.labelA5 = new System.Windows.Forms.Label();
            this.labelA6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelA7 = new System.Windows.Forms.Label();
            this.labelA8 = new System.Windows.Forms.Label();
            this.labelA9 = new System.Windows.Forms.Label();
            this.labelA10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(49, 6);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(75, 26);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(49, 43);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(75, 26);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // radioButtonApp
            // 
            this.radioButtonApp.AutoSize = true;
            this.radioButtonApp.Checked = true;
            this.radioButtonApp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonApp.Location = new System.Drawing.Point(16, 91);
            this.radioButtonApp.Name = "radioButtonApp";
            this.radioButtonApp.Size = new System.Drawing.Size(59, 23);
            this.radioButtonApp.TabIndex = 4;
            this.radioButtonApp.TabStop = true;
            this.radioButtonApp.Text = "a + b";
            this.radioButtonApp.UseVisualStyleBackColor = true;
            this.radioButtonApp.CheckedChanged += new System.EventHandler(this.radioButtonApp_CheckedChanged);
            // 
            // radioButtonSub
            // 
            this.radioButtonSub.AutoSize = true;
            this.radioButtonSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSub.Location = new System.Drawing.Point(16, 121);
            this.radioButtonSub.Name = "radioButtonSub";
            this.radioButtonSub.Size = new System.Drawing.Size(56, 23);
            this.radioButtonSub.TabIndex = 5;
            this.radioButtonSub.TabStop = true;
            this.radioButtonSub.Text = "a - b";
            this.radioButtonSub.UseVisualStyleBackColor = true;
            this.radioButtonSub.CheckedChanged += new System.EventHandler(this.radioButtonSub_CheckedChanged);
            // 
            // radioButtonMul
            // 
            this.radioButtonMul.AutoSize = true;
            this.radioButtonMul.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMul.Location = new System.Drawing.Point(16, 151);
            this.radioButtonMul.Name = "radioButtonMul";
            this.radioButtonMul.Size = new System.Drawing.Size(58, 23);
            this.radioButtonMul.TabIndex = 6;
            this.radioButtonMul.TabStop = true;
            this.radioButtonMul.Text = "a * b";
            this.radioButtonMul.UseVisualStyleBackColor = true;
            this.radioButtonMul.CheckedChanged += new System.EventHandler(this.radioButtonMul_CheckedChanged);
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonDiv.Location = new System.Drawing.Point(16, 181);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(54, 23);
            this.radioButtonDiv.TabIndex = 7;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "a / b";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            this.radioButtonDiv.CheckedChanged += new System.EventHandler(this.radioButtonDiv_CheckedChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.Enabled = false;
            this.buttonResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.Location = new System.Drawing.Point(16, 263);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(108, 30);
            this.buttonResult.TabIndex = 8;
            this.buttonResult.Text = "Считать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 9;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.labelResult.Location = new System.Drawing.Point(67, 315);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 19);
            this.labelResult.TabIndex = 10;
            // 
            // labelA1
            // 
            this.labelA1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA1.Location = new System.Drawing.Point(350, 50);
            this.labelA1.Name = "labelA1";
            this.labelA1.Size = new System.Drawing.Size(33, 19);
            this.labelA1.TabIndex = 13;
            this.labelA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA1.Visible = false;
            // 
            // labelA2
            // 
            this.labelA2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA2.Location = new System.Drawing.Point(350, 76);
            this.labelA2.Name = "labelA2";
            this.labelA2.Size = new System.Drawing.Size(33, 19);
            this.labelA2.TabIndex = 14;
            this.labelA2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA2.Visible = false;
            // 
            // labelA3
            // 
            this.labelA3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA3.Location = new System.Drawing.Point(412, 50);
            this.labelA3.Name = "labelA3";
            this.labelA3.Size = new System.Drawing.Size(73, 19);
            this.labelA3.TabIndex = 15;
            this.labelA3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA3.Visible = false;
            // 
            // labelA4
            // 
            this.labelA4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA4.Location = new System.Drawing.Point(412, 76);
            this.labelA4.Name = "labelA4";
            this.labelA4.Size = new System.Drawing.Size(73, 19);
            this.labelA4.TabIndex = 16;
            this.labelA4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA4.Visible = false;
            // 
            // labelA5
            // 
            this.labelA5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA5.Location = new System.Drawing.Point(398, 141);
            this.labelA5.Name = "labelA5";
            this.labelA5.Size = new System.Drawing.Size(73, 19);
            this.labelA5.TabIndex = 17;
            this.labelA5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA5.Visible = false;
            // 
            // labelA6
            // 
            this.labelA6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA6.Location = new System.Drawing.Point(398, 160);
            this.labelA6.Name = "labelA6";
            this.labelA6.Size = new System.Drawing.Size(73, 19);
            this.labelA6.TabIndex = 18;
            this.labelA6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA6.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(156, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 499);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelA7
            // 
            this.labelA7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA7.Location = new System.Drawing.Point(398, 185);
            this.labelA7.Name = "labelA7";
            this.labelA7.Size = new System.Drawing.Size(73, 19);
            this.labelA7.TabIndex = 19;
            this.labelA7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA7.Visible = false;
            // 
            // labelA8
            // 
            this.labelA8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA8.Location = new System.Drawing.Point(303, 376);
            this.labelA8.Name = "labelA8";
            this.labelA8.Size = new System.Drawing.Size(73, 19);
            this.labelA8.TabIndex = 20;
            this.labelA8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA8.Visible = false;
            // 
            // labelA9
            // 
            this.labelA9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA9.Location = new System.Drawing.Point(405, 376);
            this.labelA9.Name = "labelA9";
            this.labelA9.Size = new System.Drawing.Size(33, 19);
            this.labelA9.TabIndex = 21;
            this.labelA9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelA9.Visible = false;
            // 
            // labelA10
            // 
            this.labelA10.AutoSize = true;
            this.labelA10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA10.Location = new System.Drawing.Point(229, 408);
            this.labelA10.Name = "labelA10";
            this.labelA10.Size = new System.Drawing.Size(0, 22);
            this.labelA10.TabIndex = 22;
            this.labelA10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA10.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.labelA10);
            this.Controls.Add(this.labelA9);
            this.Controls.Add(this.labelA8);
            this.Controls.Add(this.labelA7);
            this.Controls.Add(this.labelA6);
            this.Controls.Add(this.labelA5);
            this.Controls.Add(this.labelA4);
            this.Controls.Add(this.labelA3);
            this.Controls.Add(this.labelA2);
            this.Controls.Add(this.labelA1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.radioButtonDiv);
            this.Controls.Add(this.radioButtonMul);
            this.Controls.Add(this.radioButtonSub);
            this.Controls.Add(this.radioButtonApp);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.RadioButton radioButtonApp;
        private System.Windows.Forms.RadioButton radioButtonSub;
        private System.Windows.Forms.RadioButton radioButtonMul;
        private System.Windows.Forms.RadioButton radioButtonDiv;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelA1;
        private System.Windows.Forms.Label labelA2;
        private System.Windows.Forms.Label labelA3;
        private System.Windows.Forms.Label labelA4;
        private System.Windows.Forms.Label labelA5;
        private System.Windows.Forms.Label labelA6;
        private System.Windows.Forms.Label labelA7;
        private System.Windows.Forms.Label labelA8;
        private System.Windows.Forms.Label labelA9;
        private System.Windows.Forms.Label labelA10;
    }
}

