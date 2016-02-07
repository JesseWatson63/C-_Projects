namespace DivisionDecVsMod___Jesse_Watson
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
            this.dividen = new System.Windows.Forms.Label();
            this.dividenTextBox = new System.Windows.Forms.TextBox();
            this.divisor = new System.Windows.Forms.Label();
            this.divisorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decimalAnswerLabelBox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.remainderLabelBox = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.quotientLabelBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dividen
            // 
            this.dividen.Location = new System.Drawing.Point(25, 13);
            this.dividen.Name = "dividen";
            this.dividen.Size = new System.Drawing.Size(54, 23);
            this.dividen.TabIndex = 0;
            this.dividen.Text = "Dividend";
            this.dividen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividenTextBox
            // 
            this.dividenTextBox.Location = new System.Drawing.Point(3, 36);
            this.dividenTextBox.Name = "dividenTextBox";
            this.dividenTextBox.Size = new System.Drawing.Size(100, 20);
            this.dividenTextBox.TabIndex = 1;
            // 
            // divisor
            // 
            this.divisor.Location = new System.Drawing.Point(209, 13);
            this.divisor.Name = "divisor";
            this.divisor.Size = new System.Drawing.Size(51, 23);
            this.divisor.TabIndex = 2;
            this.divisor.Text = "Divisor";
            this.divisor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisorTextBox
            // 
            this.divisorTextBox.Location = new System.Drawing.Point(182, 36);
            this.divisorTextBox.Name = "divisorTextBox";
            this.divisorTextBox.Size = new System.Drawing.Size(100, 20);
            this.divisorTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Divided By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(3, 62);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(279, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.decimalAnswerLabelBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.remainderLabelBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.quotientLabelBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Answers";
            // 
            // decimalAnswerLabelBox
            // 
            this.decimalAnswerLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.decimalAnswerLabelBox.Location = new System.Drawing.Point(7, 107);
            this.decimalAnswerLabelBox.Name = "decimalAnswerLabelBox";
            this.decimalAnswerLabelBox.Size = new System.Drawing.Size(247, 23);
            this.decimalAnswerLabelBox.TabIndex = 5;
            this.decimalAnswerLabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Decimal Answer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainderLabelBox
            // 
            this.remainderLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remainderLabelBox.Location = new System.Drawing.Point(154, 53);
            this.remainderLabelBox.Name = "remainderLabelBox";
            this.remainderLabelBox.Size = new System.Drawing.Size(100, 23);
            this.remainderLabelBox.TabIndex = 3;
            this.remainderLabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(154, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Remainder";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotientLabelBox
            // 
            this.quotientLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.quotientLabelBox.Location = new System.Drawing.Point(7, 53);
            this.quotientLabelBox.Name = "quotientLabelBox";
            this.quotientLabelBox.Size = new System.Drawing.Size(100, 23);
            this.quotientLabelBox.TabIndex = 1;
            this.quotientLabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quotient";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisorTextBox);
            this.Controls.Add(this.divisor);
            this.Controls.Add(this.dividenTextBox);
            this.Controls.Add(this.dividen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dividen;
        private System.Windows.Forms.TextBox dividenTextBox;
        private System.Windows.Forms.Label divisor;
        private System.Windows.Forms.TextBox divisorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label decimalAnswerLabelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label remainderLabelBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label quotientLabelBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

