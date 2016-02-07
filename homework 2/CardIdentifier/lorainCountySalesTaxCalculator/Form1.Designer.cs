namespace lorainCountySalesTaxCalculator
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
            this.moneyInput = new System.Windows.Forms.Label();
            this.dollarInput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.noUseLabel = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moneyInput
            // 
            this.moneyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moneyInput.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyInput.Location = new System.Drawing.Point(24, 44);
            this.moneyInput.Name = "moneyInput";
            this.moneyInput.Size = new System.Drawing.Size(212, 39);
            this.moneyInput.TabIndex = 0;
            this.moneyInput.Text = "Enter Dollar Amount";
            this.moneyInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dollarInput
            // 
            this.dollarInput.Location = new System.Drawing.Point(277, 55);
            this.dollarInput.Name = "dollarInput";
            this.dollarInput.Size = new System.Drawing.Size(114, 21);
            this.dollarInput.TabIndex = 1;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(24, 156);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(367, 37);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Tax Calculator";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // noUseLabel
            // 
            this.noUseLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noUseLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noUseLabel.Location = new System.Drawing.Point(24, 98);
            this.noUseLabel.Name = "noUseLabel";
            this.noUseLabel.Size = new System.Drawing.Size(212, 34);
            this.noUseLabel.TabIndex = 3;
            this.noUseLabel.Text = "Total Dollar Amount";
            this.noUseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total
            // 
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total.Location = new System.Drawing.Point(277, 98);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(114, 33);
            this.total.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 210);
            this.Controls.Add(this.total);
            this.Controls.Add(this.noUseLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.dollarInput);
            this.Controls.Add(this.moneyInput);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Sales Tax Calculator-Jesse Watson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneyInput;
        private System.Windows.Forms.TextBox dollarInput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label noUseLabel;
        private System.Windows.Forms.Label total;
    }
}

