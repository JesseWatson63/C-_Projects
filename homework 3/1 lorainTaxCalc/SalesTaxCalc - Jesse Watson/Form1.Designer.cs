namespace SalesTaxCalc___Jesse_Watson
{
    partial class calculator
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
            this.dollarTextBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.Label();
            this.totalDollarAmount = new System.Windows.Forms.Label();
            this.taxButton = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dollarTextBox
            // 
            this.dollarTextBox.Location = new System.Drawing.Point(12, 12);
            this.dollarTextBox.Name = "dollarTextBox";
            this.dollarTextBox.Size = new System.Drawing.Size(100, 20);
            this.dollarTextBox.TabIndex = 0;
            this.dollarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // taxBox
            // 
            this.taxBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxBox.Location = new System.Drawing.Point(13, 66);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(99, 23);
            this.taxBox.TabIndex = 1;
            this.taxBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalDollarAmount
            // 
            this.totalDollarAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDollarAmount.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDollarAmount.Location = new System.Drawing.Point(12, 126);
            this.totalDollarAmount.Name = "totalDollarAmount";
            this.totalDollarAmount.Size = new System.Drawing.Size(100, 23);
            this.totalDollarAmount.TabIndex = 2;
            this.totalDollarAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxButton
            // 
            this.taxButton.Location = new System.Drawing.Point(151, 38);
            this.taxButton.Name = "taxButton";
            this.taxButton.Size = new System.Drawing.Size(99, 23);
            this.taxButton.TabIndex = 3;
            this.taxButton.Text = "Calculate Tax";
            this.taxButton.UseVisualStyleBackColor = true;
            this.taxButton.Click += new System.EventHandler(this.taxButton_Click);
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(151, 98);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(99, 23);
            this.clearText.TabIndex = 4;
            this.clearText.Text = "Clear";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(13, 182);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(237, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 299);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.taxButton);
            this.Controls.Add(this.totalDollarAmount);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.dollarTextBox);
            this.Name = "calculator";
            this.Text = "Lorain Tax Calculator - Jesse Watson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dollarTextBox;
        private System.Windows.Forms.Label taxBox;
        private System.Windows.Forms.Label totalDollarAmount;
        private System.Windows.Forms.Button taxButton;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Button exit;
    }
}

