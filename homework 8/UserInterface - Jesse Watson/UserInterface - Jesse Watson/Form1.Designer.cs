namespace UserInterface___Jesse_Watson
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ncc1701D = new System.Windows.Forms.CheckBox();
            this.ncc1701 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hollowDeck = new System.Windows.Forms.CheckBox();
            this.leatherSeat = new System.Windows.Forms.CheckBox();
            this.photonTorpedo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.starShipCost = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cptGoodies = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ncc1701D);
            this.groupBox1.Controls.Add(this.ncc1701);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "StarShip To Purchase";
            // 
            // ncc1701D
            // 
            this.ncc1701D.AutoSize = true;
            this.ncc1701D.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncc1701D.Location = new System.Drawing.Point(7, 47);
            this.ncc1701D.Name = "ncc1701D";
            this.ncc1701D.Size = new System.Drawing.Size(171, 21);
            this.ncc1701D.TabIndex = 1;
            this.ncc1701D.Text = "ncc1701-D ($150,000)";
            this.ncc1701D.UseVisualStyleBackColor = true;
            // 
            // ncc1701
            // 
            this.ncc1701.AutoSize = true;
            this.ncc1701.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ncc1701.Location = new System.Drawing.Point(6, 19);
            this.ncc1701.Name = "ncc1701";
            this.ncc1701.Size = new System.Drawing.Size(155, 21);
            this.ncc1701.TabIndex = 0;
            this.ncc1701.Text = "ncc1701 ($100,000)";
            this.ncc1701.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hollowDeck);
            this.groupBox2.Controls.Add(this.leatherSeat);
            this.groupBox2.Controls.Add(this.photonTorpedo);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Captains Features";
            // 
            // hollowDeck
            // 
            this.hollowDeck.AutoSize = true;
            this.hollowDeck.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hollowDeck.Location = new System.Drawing.Point(7, 76);
            this.hollowDeck.Name = "hollowDeck";
            this.hollowDeck.Size = new System.Drawing.Size(112, 21);
            this.hollowDeck.TabIndex = 2;
            this.hollowDeck.Text = "Hollow Deck";
            this.hollowDeck.UseVisualStyleBackColor = true;
            // 
            // leatherSeat
            // 
            this.leatherSeat.AutoSize = true;
            this.leatherSeat.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leatherSeat.Location = new System.Drawing.Point(7, 48);
            this.leatherSeat.Name = "leatherSeat";
            this.leatherSeat.Size = new System.Drawing.Size(234, 21);
            this.leatherSeat.TabIndex = 1;
            this.leatherSeat.Text = "Leather Wrapped Seat For Cpt.";
            this.leatherSeat.UseVisualStyleBackColor = true;
            // 
            // photonTorpedo
            // 
            this.photonTorpedo.AutoSize = true;
            this.photonTorpedo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photonTorpedo.Location = new System.Drawing.Point(6, 20);
            this.photonTorpedo.Name = "photonTorpedo";
            this.photonTorpedo.Size = new System.Drawing.Size(226, 21);
            this.photonTorpedo.TabIndex = 0;
            this.photonTorpedo.Text = "Long Range Photon Torpedos";
            this.photonTorpedo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Engage The Price Calculator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.starShipCost);
            this.groupBox3.Location = new System.Drawing.Point(273, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cost Of StarShip";
            // 
            // starShipCost
            // 
            this.starShipCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.starShipCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starShipCost.Location = new System.Drawing.Point(6, 16);
            this.starShipCost.Name = "starShipCost";
            this.starShipCost.Size = new System.Drawing.Size(188, 23);
            this.starShipCost.TabIndex = 4;
            this.starShipCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cptGoodies);
            this.groupBox4.Location = new System.Drawing.Point(273, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 129);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "What The Cpt. Gets";
            // 
            // cptGoodies
            // 
            this.cptGoodies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cptGoodies.Location = new System.Drawing.Point(6, 16);
            this.cptGoodies.Name = "cptGoodies";
            this.cptGoodies.Size = new System.Drawing.Size(188, 99);
            this.cptGoodies.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Belay That Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(125, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Disengage This Program";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 266);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ncc1701D;
        private System.Windows.Forms.CheckBox ncc1701;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox hollowDeck;
        private System.Windows.Forms.CheckBox leatherSeat;
        private System.Windows.Forms.CheckBox photonTorpedo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label starShipCost;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label cptGoodies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

