namespace WindowsFormsApplication1
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
            this.sinister = new System.Windows.Forms.Button();
            this.dexter = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinister
            // 
            this.sinister.Location = new System.Drawing.Point(12, 98);
            this.sinister.Name = "sinister";
            this.sinister.Size = new System.Drawing.Size(75, 23);
            this.sinister.TabIndex = 0;
            this.sinister.Text = "sinister";
            this.sinister.UseVisualStyleBackColor = true;
            this.sinister.Click += new System.EventHandler(this.sinister_Click);
            // 
            // dexter
            // 
            this.dexter.Location = new System.Drawing.Point(102, 98);
            this.dexter.Name = "dexter";
            this.dexter.Size = new System.Drawing.Size(75, 23);
            this.dexter.TabIndex = 1;
            this.dexter.Text = "dexter";
            this.dexter.UseVisualStyleBackColor = true;
            this.dexter.Click += new System.EventHandler(this.dexter_Click);
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(197, 98);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(75, 23);
            this.medium.TabIndex = 2;
            this.medium.Text = "medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 30);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(102, 146);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.dexter);
            this.Controls.Add(this.sinister);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sinister;
        private System.Windows.Forms.Button dexter;
        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
    }
}

