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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAS1 = new System.Windows.Forms.Label();
            this.labelAS2 = new System.Windows.Forms.Label();
            this.labelAS3 = new System.Windows.Forms.Label();
            this.labelAS4 = new System.Windows.Forms.Label();
            this.labelAS5 = new System.Windows.Forms.Label();
            this.labelAS6 = new System.Windows.Forms.Label();
            this.labelAS7 = new System.Windows.Forms.Label();
            this.labelAS8 = new System.Windows.Forms.Label();
            this.labelAS9 = new System.Windows.Forms.Label();
            this.labelAS10 = new System.Windows.Forms.Label();
            this.genPolynomialBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(41, 17);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(75, 26);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(41, 52);
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
            this.radioButtonApp.Location = new System.Drawing.Point(6, 19);
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
            this.radioButtonSub.Location = new System.Drawing.Point(6, 48);
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
            this.radioButtonMul.Location = new System.Drawing.Point(4, 77);
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
            this.radioButtonDiv.Location = new System.Drawing.Point(4, 106);
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
            this.buttonResult.Location = new System.Drawing.Point(10, 93);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(108, 30);
            this.buttonResult.TabIndex = 8;
            this.buttonResult.Text = "Рассчитать";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(120, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 9;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Galois_fields.Properties.Resources.imgAdd;
            this.pictureBox1.Location = new System.Drawing.Point(12, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 484);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelAS1
            // 
            this.labelAS1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS1.Location = new System.Drawing.Point(200, 201);
            this.labelAS1.Name = "labelAS1";
            this.labelAS1.Size = new System.Drawing.Size(33, 19);
            this.labelAS1.TabIndex = 13;
            this.labelAS1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS1.Visible = false;
            // 
            // labelAS2
            // 
            this.labelAS2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS2.Location = new System.Drawing.Point(200, 226);
            this.labelAS2.Name = "labelAS2";
            this.labelAS2.Size = new System.Drawing.Size(33, 19);
            this.labelAS2.TabIndex = 14;
            this.labelAS2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS2.Visible = false;
            // 
            // labelAS3
            // 
            this.labelAS3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS3.Location = new System.Drawing.Point(267, 199);
            this.labelAS3.Name = "labelAS3";
            this.labelAS3.Size = new System.Drawing.Size(73, 19);
            this.labelAS3.TabIndex = 15;
            this.labelAS3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS3.Visible = false;
            // 
            // labelAS4
            // 
            this.labelAS4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS4.Location = new System.Drawing.Point(267, 226);
            this.labelAS4.Name = "labelAS4";
            this.labelAS4.Size = new System.Drawing.Size(73, 19);
            this.labelAS4.TabIndex = 16;
            this.labelAS4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS4.Visible = false;
            // 
            // labelAS5
            // 
            this.labelAS5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS5.Location = new System.Drawing.Point(254, 287);
            this.labelAS5.Name = "labelAS5";
            this.labelAS5.Size = new System.Drawing.Size(73, 19);
            this.labelAS5.TabIndex = 17;
            this.labelAS5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS5.Visible = false;
            // 
            // labelAS6
            // 
            this.labelAS6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS6.Location = new System.Drawing.Point(254, 311);
            this.labelAS6.Name = "labelAS6";
            this.labelAS6.Size = new System.Drawing.Size(73, 19);
            this.labelAS6.TabIndex = 18;
            this.labelAS6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS6.Visible = false;
            // 
            // labelAS7
            // 
            this.labelAS7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS7.Location = new System.Drawing.Point(254, 335);
            this.labelAS7.Name = "labelAS7";
            this.labelAS7.Size = new System.Drawing.Size(73, 19);
            this.labelAS7.TabIndex = 19;
            this.labelAS7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS7.Visible = false;
            // 
            // labelAS8
            // 
            this.labelAS8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS8.Location = new System.Drawing.Point(158, 522);
            this.labelAS8.Name = "labelAS8";
            this.labelAS8.Size = new System.Drawing.Size(73, 19);
            this.labelAS8.TabIndex = 20;
            this.labelAS8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS8.Visible = false;
            // 
            // labelAS9
            // 
            this.labelAS9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS9.Location = new System.Drawing.Point(260, 523);
            this.labelAS9.Name = "labelAS9";
            this.labelAS9.Size = new System.Drawing.Size(33, 19);
            this.labelAS9.TabIndex = 21;
            this.labelAS9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAS9.Visible = false;
            // 
            // labelAS10
            // 
            this.labelAS10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAS10.Location = new System.Drawing.Point(83, 556);
            this.labelAS10.Name = "labelAS10";
            this.labelAS10.Size = new System.Drawing.Size(47, 22);
            this.labelAS10.TabIndex = 22;
            this.labelAS10.Tag = "";
            this.labelAS10.Text = "123";
            this.labelAS10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAS10.Visible = false;
            // 
            // genPolynomialBox
            // 
            this.genPolynomialBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genPolynomialBox.Enabled = false;
            this.genPolynomialBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genPolynomialBox.FormattingEnabled = true;
            this.genPolynomialBox.Items.AddRange(new object[] {
            "x^8+x^4+x^3+x^2+1",
            "x^8+x^5+x^3+x+1",
            "x^8+x^5+x^3+x^2+1",
            "x^8+x^6+x^3+x^2+1",
            "x^8+x^6+x^4+x^3+x^2+x+1",
            "x^8+x^6+x^5+x+1",
            "x^8+x^6+x^5+x^2+1",
            "x^8+x^6+x^5+x^3+1",
            "x^8+x^6+x^5+x^4+1",
            "x^8+x^7+x^2+x+1",
            "x^8+x^7+x^3+x^2+1",
            "x^8+x^7+x^5+x^3+1",
            "x^8+x^7+x^6+x+1",
            "x^8+x^7+x^6+x^3+x^2+x+1",
            "x^8+x^7+x^6+x^5+x^2+x+1",
            "x^8+x^7+x^6+x^5+x^4+x^2+1"});
            this.genPolynomialBox.Location = new System.Drawing.Point(120, 19);
            this.genPolynomialBox.Name = "genPolynomialBox";
            this.genPolynomialBox.Size = new System.Drawing.Size(208, 27);
            this.genPolynomialBox.TabIndex = 23;
            this.genPolynomialBox.Tag = "";
            this.genPolynomialBox.SelectedIndexChanged += new System.EventHandler(this.genPolynomial_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxB);
            this.groupBox1.Controls.Add(this.buttonResult);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 136);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Значения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResult);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.radioButtonMul);
            this.groupBox2.Controls.Add(this.radioButtonDiv);
            this.groupBox2.Controls.Add(this.genPolynomialBox);
            this.groupBox2.Controls.Add(this.radioButtonApp);
            this.groupBox2.Controls.Add(this.radioButtonSub);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 136);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции и порождающий полином";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(307, 77);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 17);
            this.labelResult.TabIndex = 27;
            this.labelResult.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(116, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Операция и результат:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(624, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAS10);
            this.Controls.Add(this.labelAS9);
            this.Controls.Add(this.labelAS8);
            this.Controls.Add(this.labelAS7);
            this.Controls.Add(this.labelAS6);
            this.Controls.Add(this.labelAS5);
            this.Controls.Add(this.labelAS4);
            this.Controls.Add(this.labelAS3);
            this.Controls.Add(this.labelAS2);
            this.Controls.Add(this.labelAS1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Простейшие мат. операции с полями Галуа";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAS1;
        private System.Windows.Forms.Label labelAS2;
        private System.Windows.Forms.Label labelAS3;
        private System.Windows.Forms.Label labelAS4;
        private System.Windows.Forms.Label labelAS5;
        private System.Windows.Forms.Label labelAS6;
        private System.Windows.Forms.Label labelAS7;
        private System.Windows.Forms.Label labelAS8;
        private System.Windows.Forms.Label labelAS9;
        private System.Windows.Forms.Label labelAS10;
        private System.Windows.Forms.ComboBox genPolynomialBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResult;
    }
}

