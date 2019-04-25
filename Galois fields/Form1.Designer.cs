namespace Galois_fields
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "b =";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxA.Location = new System.Drawing.Point(49, 6);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(75, 26);
            this.textBoxA.TabIndex = 2;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.radioButtonApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonApp.Location = new System.Drawing.Point(16, 91);
            this.radioButtonApp.Name = "radioButtonApp";
            this.radioButtonApp.Size = new System.Drawing.Size(62, 24);
            this.radioButtonApp.TabIndex = 4;
            this.radioButtonApp.TabStop = true;
            this.radioButtonApp.Text = "a + b";
            this.radioButtonApp.UseVisualStyleBackColor = true;
            this.radioButtonApp.CheckedChanged += new System.EventHandler(this.radioButtonApp_CheckedChanged);
            // 
            // radioButtonSub
            // 
            this.radioButtonSub.AutoSize = true;
            this.radioButtonSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonSub.Location = new System.Drawing.Point(16, 121);
            this.radioButtonSub.Name = "radioButtonSub";
            this.radioButtonSub.Size = new System.Drawing.Size(58, 24);
            this.radioButtonSub.TabIndex = 5;
            this.radioButtonSub.TabStop = true;
            this.radioButtonSub.Text = "a - b";
            this.radioButtonSub.UseVisualStyleBackColor = true;
            this.radioButtonSub.CheckedChanged += new System.EventHandler(this.radioButtonSub_CheckedChanged);
            // 
            // radioButtonMul
            // 
            this.radioButtonMul.AutoSize = true;
            this.radioButtonMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonMul.Location = new System.Drawing.Point(16, 151);
            this.radioButtonMul.Name = "radioButtonMul";
            this.radioButtonMul.Size = new System.Drawing.Size(59, 24);
            this.radioButtonMul.TabIndex = 6;
            this.radioButtonMul.TabStop = true;
            this.radioButtonMul.Text = "a * b";
            this.radioButtonMul.UseVisualStyleBackColor = true;
            this.radioButtonMul.CheckedChanged += new System.EventHandler(this.radioButtonMul_CheckedChanged);
            // 
            // radioButtonDiv
            // 
            this.radioButtonDiv.AutoSize = true;
            this.radioButtonDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButtonDiv.Location = new System.Drawing.Point(16, 181);
            this.radioButtonDiv.Name = "radioButtonDiv";
            this.radioButtonDiv.Size = new System.Drawing.Size(57, 24);
            this.radioButtonDiv.TabIndex = 7;
            this.radioButtonDiv.TabStop = true;
            this.radioButtonDiv.Text = "a / b";
            this.radioButtonDiv.UseVisualStyleBackColor = true;
            this.radioButtonDiv.CheckedChanged += new System.EventHandler(this.radioButtonDiv_CheckedChanged);
            // 
            // buttonResult
            // 
            this.buttonResult.Enabled = false;
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "a + b =";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResult.Location = new System.Drawing.Point(67, 315);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 507);
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
    }
}

