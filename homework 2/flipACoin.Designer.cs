namespace Coin_Flipper
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
            this.flip1 = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Button();
            this.dontQuit = new System.Windows.Forms.Button();
            this.headsUp = new System.Windows.Forms.PictureBox();
            this.tails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.headsUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tails)).BeginInit();
            this.SuspendLayout();
            // 
            // flip1
            // 
            this.flip1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flip1.Location = new System.Drawing.Point(12, 161);
            this.flip1.Name = "flip1";
            this.flip1.Size = new System.Drawing.Size(260, 50);
            this.flip1.TabIndex = 0;
            this.flip1.Text = "Flip a coin theres a winner everytime";
            this.flip1.UseVisualStyleBackColor = true;
            this.flip1.Click += new System.EventHandler(this.flip1_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.Location = new System.Drawing.Point(12, 218);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(129, 23);
            this.tryAgain.TabIndex = 1;
            this.tryAgain.Text = "Try Again";
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.tryAgain_Click);
            // 
            // dontQuit
            // 
            this.dontQuit.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dontQuit.Location = new System.Drawing.Point(147, 217);
            this.dontQuit.Name = "dontQuit";
            this.dontQuit.Size = new System.Drawing.Size(118, 23);
            this.dontQuit.TabIndex = 2;
            this.dontQuit.Text = "Dont Quit Yet";
            this.dontQuit.UseVisualStyleBackColor = true;
            this.dontQuit.Click += new System.EventHandler(this.dontQuit_Click);
            // 
            // headsUp
            // 
            this.headsUp.Image = ((System.Drawing.Image)(resources.GetObject("headsUp.Image")));
            this.headsUp.Location = new System.Drawing.Point(64, 3);
            this.headsUp.Name = "headsUp";
            this.headsUp.Size = new System.Drawing.Size(127, 123);
            this.headsUp.TabIndex = 3;
            this.headsUp.TabStop = false;
            this.headsUp.Visible = false;
            // 
            // tails
            // 
            this.tails.Image = ((System.Drawing.Image)(resources.GetObject("tails.Image")));
            this.tails.Location = new System.Drawing.Point(64, 3);
            this.tails.Name = "tails";
            this.tails.Size = new System.Drawing.Size(127, 123);
            this.tails.TabIndex = 4;
            this.tails.TabStop = false;
            this.tails.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tails);
            this.Controls.Add(this.headsUp);
            this.Controls.Add(this.dontQuit);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.flip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.headsUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flip1;
        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Button dontQuit;
        private System.Windows.Forms.PictureBox headsUp;
        private System.Windows.Forms.PictureBox tails;
    }
}

