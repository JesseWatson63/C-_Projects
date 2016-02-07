namespace LoopListBoxMod___jesse_watson
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
            this.startYears1 = new System.Windows.Forms.TextBox();
            this.endYears1 = new System.Windows.Forms.TextBox();
            this.president = new System.Windows.Forms.CheckBox();
            this.census = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Year (YYYY)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Mistral", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Year (YYYY)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startYears1
            // 
            this.startYears1.Location = new System.Drawing.Point(54, 40);
            this.startYears1.Name = "startYears1";
            this.startYears1.Size = new System.Drawing.Size(69, 20);
            this.startYears1.TabIndex = 2;
            // 
            // endYears1
            // 
            this.endYears1.Location = new System.Drawing.Point(243, 40);
            this.endYears1.Name = "endYears1";
            this.endYears1.Size = new System.Drawing.Size(69, 20);
            this.endYears1.TabIndex = 3;
            // 
            // president
            // 
            this.president.AutoSize = true;
            this.president.Location = new System.Drawing.Point(18, 78);
            this.president.Name = "president";
            this.president.Size = new System.Drawing.Size(126, 17);
            this.president.TabIndex = 4;
            this.president.Text = "Presidential Elections";
            this.president.UseVisualStyleBackColor = true;
            // 
            // census
            // 
            this.census.AutoSize = true;
            this.census.Location = new System.Drawing.Point(161, 78);
            this.census.Name = "census";
            this.census.Size = new System.Drawing.Size(91, 17);
            this.census.TabIndex = 5;
            this.census.Text = "Census Years";
            this.census.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 147);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.census);
            this.Controls.Add(this.president);
            this.Controls.Add(this.endYears1);
            this.Controls.Add(this.startYears1);
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
        private System.Windows.Forms.TextBox startYears1;
        private System.Windows.Forms.TextBox endYears1;
        private System.Windows.Forms.CheckBox president;
        private System.Windows.Forms.CheckBox census;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

