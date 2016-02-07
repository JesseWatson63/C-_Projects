namespace TextboxCalcs_PRECLASS
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
            this.myTxtBoxLengthIn = new System.Windows.Forms.TextBox();
            this.myTxtBoxWidthIn = new System.Windows.Forms.TextBox();
            this.myTxtBoxHeightIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.myLblCalcCubicFeetDetail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.myLblCalcCubicYardsDetail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.myLblCalcCostDetail = new System.Windows.Forms.Label();
            this.myLblPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myTxtBoxLengthIn
            // 
            this.myTxtBoxLengthIn.Location = new System.Drawing.Point(152, 42);
            this.myTxtBoxLengthIn.Name = "myTxtBoxLengthIn";
            this.myTxtBoxLengthIn.Size = new System.Drawing.Size(70, 20);
            this.myTxtBoxLengthIn.TabIndex = 0;
            // 
            // myTxtBoxWidthIn
            // 
            this.myTxtBoxWidthIn.Location = new System.Drawing.Point(152, 74);
            this.myTxtBoxWidthIn.Name = "myTxtBoxWidthIn";
            this.myTxtBoxWidthIn.Size = new System.Drawing.Size(70, 20);
            this.myTxtBoxWidthIn.TabIndex = 1;
            // 
            // myTxtBoxHeightIn
            // 
            this.myTxtBoxHeightIn.Location = new System.Drawing.Point(152, 107);
            this.myTxtBoxHeightIn.Name = "myTxtBoxHeightIn";
            this.myTxtBoxHeightIn.Size = new System.Drawing.Size(70, 20);
            this.myTxtBoxHeightIn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Length (ft)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Width (ft)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Height (ft)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // myLblCalcCubicFeetDetail
            // 
            this.myLblCalcCubicFeetDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLblCalcCubicFeetDetail.Location = new System.Drawing.Point(117, 174);
            this.myLblCalcCubicFeetDetail.Name = "myLblCalcCubicFeetDetail";
            this.myLblCalcCubicFeetDetail.Size = new System.Drawing.Size(70, 23);
            this.myLblCalcCubicFeetDetail.TabIndex = 7;
            this.myLblCalcCubicFeetDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(29, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cubic Feet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cubic Yards";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // myLblCalcCubicYardsDetail
            // 
            this.myLblCalcCubicYardsDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLblCalcCubicYardsDetail.Location = new System.Drawing.Point(117, 207);
            this.myLblCalcCubicYardsDetail.Name = "myLblCalcCubicYardsDetail";
            this.myLblCalcCubicYardsDetail.Size = new System.Drawing.Size(70, 23);
            this.myLblCalcCubicYardsDetail.TabIndex = 9;
            this.myLblCalcCubicYardsDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(46, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = " x ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // myLblCalcCostDetail
            // 
            this.myLblCalcCostDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLblCalcCostDetail.Location = new System.Drawing.Point(216, 239);
            this.myLblCalcCostDetail.Name = "myLblCalcCostDetail";
            this.myLblCalcCostDetail.Size = new System.Drawing.Size(65, 23);
            this.myLblCalcCostDetail.TabIndex = 11;
            this.myLblCalcCostDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // myLblPrice
            // 
            this.myLblPrice.Location = new System.Drawing.Point(117, 239);
            this.myLblPrice.Name = "myLblPrice";
            this.myLblPrice.Size = new System.Drawing.Size(93, 23);
            this.myLblPrice.TabIndex = 13;
            this.myLblPrice.Text = "Price";
            this.myLblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "MULCH CALCULATOR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 282);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.myLblPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.myLblCalcCostDetail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.myLblCalcCubicYardsDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.myLblCalcCubicFeetDetail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myTxtBoxHeightIn);
            this.Controls.Add(this.myTxtBoxWidthIn);
            this.Controls.Add(this.myTxtBoxLengthIn);
            this.Name = "Form1";
            this.Text = "Demo Mulch Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox myTxtBoxLengthIn;
        private System.Windows.Forms.TextBox myTxtBoxWidthIn;
        private System.Windows.Forms.TextBox myTxtBoxHeightIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label myLblCalcCubicFeetDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label myLblCalcCubicYardsDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label myLblCalcCostDetail;
        private System.Windows.Forms.Label myLblPrice;
        private System.Windows.Forms.Label label8;
    }
}

