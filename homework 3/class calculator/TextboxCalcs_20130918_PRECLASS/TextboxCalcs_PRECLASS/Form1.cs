using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextboxCalcs_PRECLASS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //these variables are constant/fixed and may be used in more than one place
        const decimal constConvCubicFeetToYards = 27;
        const decimal constPricePerCubicYard = 40;
        //also add m if decimal literal   const decimal constPricePerCubicYard = 40.99m;

        //our calculate button/event handler/method

        private void button1_Click(object sender, EventArgs e)
        {
            //these variables hold the numeric version of what the user typed in
            decimal lengthInDec = 0;
            decimal widthInDec = 0;
            decimal heightInDec = 0;

            //these variables are needed to hold the results of calcuations
            decimal calcCubicFeetDetailDec = 0;
            decimal calcCubicYardsDetailDec = 0;
            decimal calcCostDetailDec = 0;

            //INPUT
            //take the INPUT textbox data from form and convert to numeric data
            //store result in local variables
            lengthInDec = decimal.Parse(myTxtBoxLengthIn.Text);
            widthInDec = decimal.Parse(myTxtBoxWidthIn.Text);
            heightInDec = decimal.Parse(myTxtBoxHeightIn.Text);

            //PROCESSING
            //perform calculations using the numeric variables, save in local variables
            calcCubicFeetDetailDec = (lengthInDec * widthInDec * heightInDec);
            calcCubicYardsDetailDec = (calcCubicFeetDetailDec / constConvCubicFeetToYards);

            calcCostDetailDec = (calcCubicYardsDetailDec * constPricePerCubicYard);

            //OUTPUT
            //convert the numeric data into text for output on the Windows form
            myLblCalcCubicFeetDetail.Text = calcCubicFeetDetailDec.ToString();
            myLblCalcCubicYardsDetail.Text = calcCubicYardsDetailDec.ToString();
            myLblCalcCostDetail.Text = calcCostDetailDec.ToString();
            myLblPrice.Text = constPricePerCubicYard.ToString() + " per Yard = ";

            //MISC COMMENTS
            //MessageBox.Show(calcCubicFeetDec.ToString());
            //MessageBox.Show(calcCubicYardsDec.ToString());

            //Other Examples of the ToString() Method numeric/decimals and Currency output
            //myLblCalcCubicFeetDetail.Text = calcCubicFeetDetailDec.ToString("N2");
            //myLblCalcCubicYardsDetail.Text = calcCubicYardsDetailDec.ToString("N1");
            //myLblCalcCostDetail.Text = calcCostDetailDec.ToString("C");
            //myLblPrice.Text = constPricePerCubicYard.ToString("C");

            //LATER
            //Show Try Catch
            //Show decimal.TryParse(textfield,out outfieldDec) <> 0
            

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
