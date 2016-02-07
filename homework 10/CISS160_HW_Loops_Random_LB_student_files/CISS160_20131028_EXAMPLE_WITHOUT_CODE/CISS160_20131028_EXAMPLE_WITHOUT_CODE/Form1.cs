using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20131028_EXAMPLE_STU_STARTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DECLARE CLASS LEVEL FIELD VARIABLES
        int CONST_cashPayoutPick3 = 500;
        int CONST_cashPayoutPick4 = 5000;
        int CONST_cashPayoutPick5 = 50000;

        private void myBtnGenRandomNumbers_Click(object sender, EventArgs e)
        {
            
            Random myRandomNumberObject = new Random();

            //clear the list box
            decimal numberOfAttempts = 0;


            //LOOP THROUGH AND CREATE SETS OF 3 RANDOM DIGITS EACH TIME THROUGH LOOP UNTIL A MATCH IS FOUND OR TRY 10,000 TIMES
            while (true)  //before uncommenting this line, make sure you do not have an 'infinite loop'/be sure to brak out of your while somewhere
            {
                numberOfAttempts++;

                //make sure number of tries is not more than 10,000; if it is more than 10,00 exit the loop with a break; command

                int myRandomNumber1 = myRandomNumberGenerator.Next(0, 10);

                int myRandomNumber2 = myRandomNumberGenerator.Next(0, 10);

                int myRandomNumber3 = myRandomNumberGenerator.Next(0, 10);

                //display the number of match attempts so far

                //display the generated digit 1,2,3 in the labels on the Form

                //set the Label BackColor of all the generated digits to Color.LightGray


                //for any generated digit that matches the winning digit,
                //  -set the Label BackColor = Color.LightGreen
                //  -keep track of the matching status of each digit in a boolean



                //check all three boolean match variables, if they are all true then we have a match to the winning number, exit out of the while
                /*
                if (??)
                {
                    //add what happened to the event log

                    //break out of while loop since found a match
                    break;
                    //
                }
                else
                {
                    //add what happened to the event log

                    //no need to break out of loop; keep looping
                }
                */

            }  // End of While


            //FINAL OUTPUT
            //display the payout if numbers do match
            myLblCashPayout.Text = CONST_cashPayoutPick3.ToString("c0"); 
            
            //display a message summarizing the end result
            /*
            if (???)
            {
                MessageBox.Show("Match Found for All 3 Digits - it took " + numMatchAttemptsInt.ToString("n0") + " tries!");
            }
            else
            {
                MessageBox.Show("No Match Found - After " + numMatchAttemptsInt.ToString("n0") + " tries");
            }
            */

        }
    }
}
