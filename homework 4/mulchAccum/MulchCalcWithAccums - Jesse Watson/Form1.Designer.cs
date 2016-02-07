namespace MulchCalcWithAccums___Jesse_Watson
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
            this.lengthFeet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.feetHeightInput = new System.Windows.Forms.TextBox();
            this.heigtFeet = new System.Windows.Forms.Label();
            this.feetWidthInput = new System.Windows.Forms.TextBox();
            this.widthFeet = new System.Windows.Forms.Label();
            this.feetLengthInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceOutput = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.cubicYardOutput = new System.Windows.Forms.Label();
            this.cubicYard = new System.Windows.Forms.Label();
            this.feetCubicOutput = new System.Windows.Forms.Label();
            this.cubicFeet = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.greenDump = new System.Windows.Forms.PictureBox();
            this.redDump = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.truckLoad = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalMulchAccum = new System.Windows.Forms.Label();
            this.totalMulch = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.totalOrder = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.greenDump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDump)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthFeet
            // 
            this.lengthFeet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthFeet.Location = new System.Drawing.Point(6, 25);
            this.lengthFeet.Name = "lengthFeet";
            this.lengthFeet.Size = new System.Drawing.Size(119, 17);
            this.lengthFeet.TabIndex = 0;
            this.lengthFeet.Text = "Length In Feet";
            this.lengthFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feetHeightInput);
            this.groupBox1.Controls.Add(this.heigtFeet);
            this.groupBox1.Controls.Add(this.feetWidthInput);
            this.groupBox1.Controls.Add(this.widthFeet);
            this.groupBox1.Controls.Add(this.feetLengthInput);
            this.groupBox1.Controls.Add(this.lengthFeet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measurements";
            // 
            // feetHeightInput
            // 
            this.feetHeightInput.Location = new System.Drawing.Point(131, 77);
            this.feetHeightInput.Name = "feetHeightInput";
            this.feetHeightInput.Size = new System.Drawing.Size(100, 20);
            this.feetHeightInput.TabIndex = 5;
            // 
            // heigtFeet
            // 
            this.heigtFeet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heigtFeet.Location = new System.Drawing.Point(6, 77);
            this.heigtFeet.Name = "heigtFeet";
            this.heigtFeet.Size = new System.Drawing.Size(119, 20);
            this.heigtFeet.TabIndex = 4;
            this.heigtFeet.Text = "Height In Feet";
            this.heigtFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feetWidthInput
            // 
            this.feetWidthInput.Location = new System.Drawing.Point(131, 51);
            this.feetWidthInput.Name = "feetWidthInput";
            this.feetWidthInput.Size = new System.Drawing.Size(100, 20);
            this.feetWidthInput.TabIndex = 3;
            // 
            // widthFeet
            // 
            this.widthFeet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthFeet.Location = new System.Drawing.Point(6, 54);
            this.widthFeet.Name = "widthFeet";
            this.widthFeet.Size = new System.Drawing.Size(116, 13);
            this.widthFeet.TabIndex = 2;
            this.widthFeet.Text = "Width In Feet";
            this.widthFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feetLengthInput
            // 
            this.feetLengthInput.Location = new System.Drawing.Point(131, 22);
            this.feetLengthInput.Name = "feetLengthInput";
            this.feetLengthInput.Size = new System.Drawing.Size(100, 20);
            this.feetLengthInput.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceOutput);
            this.groupBox2.Controls.Add(this.totalCost);
            this.groupBox2.Controls.Add(this.cubicYardOutput);
            this.groupBox2.Controls.Add(this.cubicYard);
            this.groupBox2.Controls.Add(this.feetCubicOutput);
            this.groupBox2.Controls.Add(this.cubicFeet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Order";
            // 
            // priceOutput
            // 
            this.priceOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOutput.Location = new System.Drawing.Point(131, 94);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.Size = new System.Drawing.Size(100, 29);
            this.priceOutput.TabIndex = 5;
            this.priceOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalCost
            // 
            this.totalCost.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.Location = new System.Drawing.Point(11, 88);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(111, 40);
            this.totalCost.TabIndex = 4;
            this.totalCost.Text = "$30.00 Per Cubic Yard";
            this.totalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cubicYardOutput
            // 
            this.cubicYardOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cubicYardOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicYardOutput.Location = new System.Drawing.Point(131, 54);
            this.cubicYardOutput.Name = "cubicYardOutput";
            this.cubicYardOutput.Size = new System.Drawing.Size(100, 26);
            this.cubicYardOutput.TabIndex = 3;
            this.cubicYardOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cubicYard
            // 
            this.cubicYard.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicYard.Location = new System.Drawing.Point(9, 61);
            this.cubicYard.Name = "cubicYard";
            this.cubicYard.Size = new System.Drawing.Size(113, 13);
            this.cubicYard.TabIndex = 2;
            this.cubicYard.Text = "Cubic Yard";
            this.cubicYard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feetCubicOutput
            // 
            this.feetCubicOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feetCubicOutput.Location = new System.Drawing.Point(131, 16);
            this.feetCubicOutput.Name = "feetCubicOutput";
            this.feetCubicOutput.Size = new System.Drawing.Size(100, 25);
            this.feetCubicOutput.TabIndex = 1;
            this.feetCubicOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cubicFeet
            // 
            this.cubicFeet.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicFeet.Location = new System.Drawing.Point(6, 24);
            this.cubicFeet.Name = "cubicFeet";
            this.cubicFeet.Size = new System.Drawing.Size(116, 17);
            this.cubicFeet.TabIndex = 0;
            this.cubicFeet.Text = "Cubic Feet";
            this.cubicFeet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(163, 146);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(42, 146);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // greenDump
            // 
            this.greenDump.Image = ((System.Drawing.Image)(resources.GetObject("greenDump.Image")));
            this.greenDump.Location = new System.Drawing.Point(16, 16);
            this.greenDump.Name = "greenDump";
            this.greenDump.Size = new System.Drawing.Size(141, 97);
            this.greenDump.TabIndex = 5;
            this.greenDump.TabStop = false;
            this.greenDump.Visible = false;
            // 
            // redDump
            // 
            this.redDump.Image = ((System.Drawing.Image)(resources.GetObject("redDump.Image")));
            this.redDump.Location = new System.Drawing.Point(16, 16);
            this.redDump.Name = "redDump";
            this.redDump.Size = new System.Drawing.Size(141, 96);
            this.redDump.TabIndex = 6;
            this.redDump.TabStop = false;
            this.redDump.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.truckLoad);
            this.groupBox3.Controls.Add(this.redDump);
            this.groupBox3.Controls.Add(this.greenDump);
            this.groupBox3.Location = new System.Drawing.Point(285, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 157);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1 Order Truck Capacity";
            // 
            // truckLoad
            // 
            this.truckLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.truckLoad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.truckLoad.Location = new System.Drawing.Point(16, 116);
            this.truckLoad.Name = "truckLoad";
            this.truckLoad.Size = new System.Drawing.Size(141, 23);
            this.truckLoad.TabIndex = 7;
            this.truckLoad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalOrder);
            this.groupBox4.Controls.Add(this.order);
            this.groupBox4.Controls.Add(this.totalMulchAccum);
            this.groupBox4.Controls.Add(this.totalMulch);
            this.groupBox4.Location = new System.Drawing.Point(285, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 115);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Accumulated Orders";
            // 
            // totalMulchAccum
            // 
            this.totalMulchAccum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalMulchAccum.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMulchAccum.Location = new System.Drawing.Point(36, 39);
            this.totalMulchAccum.Name = "totalMulchAccum";
            this.totalMulchAccum.Size = new System.Drawing.Size(100, 23);
            this.totalMulchAccum.TabIndex = 1;
            this.totalMulchAccum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalMulch
            // 
            this.totalMulch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMulch.Location = new System.Drawing.Point(36, 16);
            this.totalMulch.Name = "totalMulch";
            this.totalMulch.Size = new System.Drawing.Size(100, 23);
            this.totalMulch.TabIndex = 0;
            this.totalMulch.Text = "Total Mulch";
            this.totalMulch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(36, 62);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(100, 23);
            this.order.TabIndex = 2;
            this.order.Text = "Total Orders";
            this.order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOrder
            // 
            this.totalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOrder.Location = new System.Drawing.Point(36, 88);
            this.totalOrder.Name = "totalOrder";
            this.totalOrder.Size = new System.Drawing.Size(100, 23);
            this.totalOrder.TabIndex = 3;
            this.totalOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear Accum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.greenDump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redDump)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lengthFeet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox feetHeightInput;
        private System.Windows.Forms.Label heigtFeet;
        private System.Windows.Forms.TextBox feetWidthInput;
        private System.Windows.Forms.Label widthFeet;
        private System.Windows.Forms.TextBox feetLengthInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label feetCubicOutput;
        private System.Windows.Forms.Label cubicFeet;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label cubicYardOutput;
        private System.Windows.Forms.Label cubicYard;
        private System.Windows.Forms.Label priceOutput;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.PictureBox greenDump;
        private System.Windows.Forms.PictureBox redDump;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label truckLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label totalMulchAccum;
        private System.Windows.Forms.Label totalMulch;
        private System.Windows.Forms.Label totalOrder;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

