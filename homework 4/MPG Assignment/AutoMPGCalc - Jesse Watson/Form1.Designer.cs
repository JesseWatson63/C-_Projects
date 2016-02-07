namespace AutoMPGCalc___Jesse_Watson
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
            this.fillUpMiles1 = new System.Windows.Forms.TextBox();
            this.milesAtFillup1 = new System.Windows.Forms.Label();
            this.fillUpMiles2 = new System.Windows.Forms.TextBox();
            this.milesAtFillup2 = new System.Windows.Forms.Label();
            this.gallonsAtFillup = new System.Windows.Forms.Label();
            this.gallonsEntry = new System.Windows.Forms.TextBox();
            this.ppg = new System.Windows.Forms.TextBox();
            this.pricePerGallon = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.FuelCostPerMile = new System.Windows.Forms.Label();
            this.fuelCost = new System.Windows.Forms.Label();
            this.totalMPG = new System.Windows.Forms.Label();
            this.mpgText = new System.Windows.Forms.Label();
            this.totalMilesTraveled = new System.Windows.Forms.Label();
            this.miles = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillUpMiles1
            // 
            this.fillUpMiles1.Location = new System.Drawing.Point(150, 32);
            this.fillUpMiles1.Name = "fillUpMiles1";
            this.fillUpMiles1.Size = new System.Drawing.Size(94, 20);
            this.fillUpMiles1.TabIndex = 0;
            // 
            // milesAtFillup1
            // 
            this.milesAtFillup1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesAtFillup1.Location = new System.Drawing.Point(6, 32);
            this.milesAtFillup1.Name = "milesAtFillup1";
            this.milesAtFillup1.Size = new System.Drawing.Size(135, 23);
            this.milesAtFillup1.TabIndex = 1;
            this.milesAtFillup1.Text = "Miles At Fillup #1";
            this.milesAtFillup1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillUpMiles2
            // 
            this.fillUpMiles2.Location = new System.Drawing.Point(150, 70);
            this.fillUpMiles2.Name = "fillUpMiles2";
            this.fillUpMiles2.Size = new System.Drawing.Size(94, 20);
            this.fillUpMiles2.TabIndex = 2;
            // 
            // milesAtFillup2
            // 
            this.milesAtFillup2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesAtFillup2.Location = new System.Drawing.Point(6, 71);
            this.milesAtFillup2.Name = "milesAtFillup2";
            this.milesAtFillup2.Size = new System.Drawing.Size(132, 23);
            this.milesAtFillup2.TabIndex = 3;
            this.milesAtFillup2.Text = "Miles At Fillup #2";
            this.milesAtFillup2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsAtFillup
            // 
            this.gallonsAtFillup.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gallonsAtFillup.Location = new System.Drawing.Point(6, 107);
            this.gallonsAtFillup.Name = "gallonsAtFillup";
            this.gallonsAtFillup.Size = new System.Drawing.Size(143, 23);
            this.gallonsAtFillup.TabIndex = 4;
            this.gallonsAtFillup.Text = "Gallons At Fillup #2";
            this.gallonsAtFillup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gallonsEntry
            // 
            this.gallonsEntry.Location = new System.Drawing.Point(150, 106);
            this.gallonsEntry.Name = "gallonsEntry";
            this.gallonsEntry.Size = new System.Drawing.Size(94, 20);
            this.gallonsEntry.TabIndex = 5;
            // 
            // ppg
            // 
            this.ppg.Location = new System.Drawing.Point(150, 141);
            this.ppg.Name = "ppg";
            this.ppg.Size = new System.Drawing.Size(94, 20);
            this.ppg.TabIndex = 6;
            // 
            // pricePerGallon
            // 
            this.pricePerGallon.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerGallon.Location = new System.Drawing.Point(6, 142);
            this.pricePerGallon.Name = "pricePerGallon";
            this.pricePerGallon.Size = new System.Drawing.Size(116, 23);
            this.pricePerGallon.TabIndex = 7;
            this.pricePerGallon.Text = "Price Per Gallon";
            this.pricePerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.milesAtFillup1);
            this.groupBox1.Controls.Add(this.pricePerGallon);
            this.groupBox1.Controls.Add(this.fillUpMiles1);
            this.groupBox1.Controls.Add(this.ppg);
            this.groupBox1.Controls.Add(this.fillUpMiles2);
            this.groupBox1.Controls.Add(this.gallonsEntry);
            this.groupBox1.Controls.Add(this.milesAtFillup2);
            this.groupBox1.Controls.Add(this.gallonsAtFillup);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.closeButton);
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.calculateButton);
            this.groupBox2.Controls.Add(this.FuelCostPerMile);
            this.groupBox2.Controls.Add(this.fuelCost);
            this.groupBox2.Controls.Add(this.totalMPG);
            this.groupBox2.Controls.Add(this.mpgText);
            this.groupBox2.Controls.Add(this.totalMilesTraveled);
            this.groupBox2.Controls.Add(this.miles);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 233);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Results";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 187);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(232, 23);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 148);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(144, 148);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // FuelCostPerMile
            // 
            this.FuelCostPerMile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FuelCostPerMile.Location = new System.Drawing.Point(144, 99);
            this.FuelCostPerMile.Name = "FuelCostPerMile";
            this.FuelCostPerMile.Size = new System.Drawing.Size(100, 23);
            this.FuelCostPerMile.TabIndex = 5;
            this.FuelCostPerMile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fuelCost
            // 
            this.fuelCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fuelCost.Location = new System.Drawing.Point(9, 99);
            this.fuelCost.Name = "fuelCost";
            this.fuelCost.Size = new System.Drawing.Size(100, 38);
            this.fuelCost.TabIndex = 4;
            this.fuelCost.Text = "Fuel Cost Per Mile";
            this.fuelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMPG
            // 
            this.totalMPG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMPG.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMPG.Location = new System.Drawing.Point(144, 62);
            this.totalMPG.Name = "totalMPG";
            this.totalMPG.Size = new System.Drawing.Size(100, 23);
            this.totalMPG.TabIndex = 3;
            this.totalMPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mpgText
            // 
            this.mpgText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mpgText.Location = new System.Drawing.Point(9, 62);
            this.mpgText.Name = "mpgText";
            this.mpgText.Size = new System.Drawing.Size(100, 23);
            this.mpgText.TabIndex = 2;
            this.mpgText.Text = "Total MPG";
            this.mpgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMilesTraveled
            // 
            this.totalMilesTraveled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMilesTraveled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMilesTraveled.Location = new System.Drawing.Point(144, 30);
            this.totalMilesTraveled.Name = "totalMilesTraveled";
            this.totalMilesTraveled.Size = new System.Drawing.Size(100, 23);
            this.totalMilesTraveled.TabIndex = 1;
            this.totalMilesTraveled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // miles
            // 
            this.miles.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miles.Location = new System.Drawing.Point(9, 20);
            this.miles.Name = "miles";
            this.miles.Size = new System.Drawing.Size(129, 38);
            this.miles.TabIndex = 0;
            this.miles.Text = "Total Miles Traveled";
            this.miles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AutoMpgCalc - Jesse Watson";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox fillUpMiles1;
        private System.Windows.Forms.Label milesAtFillup1;
        private System.Windows.Forms.TextBox fillUpMiles2;
        private System.Windows.Forms.Label milesAtFillup2;
        private System.Windows.Forms.Label gallonsAtFillup;
        private System.Windows.Forms.TextBox gallonsEntry;
        private System.Windows.Forms.TextBox ppg;
        private System.Windows.Forms.Label pricePerGallon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label FuelCostPerMile;
        private System.Windows.Forms.Label fuelCost;
        private System.Windows.Forms.Label totalMPG;
        private System.Windows.Forms.Label mpgText;
        private System.Windows.Forms.Label totalMilesTraveled;
        private System.Windows.Forms.Label miles;
    }
}

