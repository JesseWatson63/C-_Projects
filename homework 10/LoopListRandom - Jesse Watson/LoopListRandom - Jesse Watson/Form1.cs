using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//jesse watson
//256777
//11-8-2013
//The purpose of this program is to show you its really hard to guess three numbers and win
namespace LoopListRandom___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is the beginning of my lottery
        private void button1_Click(object sender, EventArgs e)
        {
            //these are so that everytime the button is clicked they the numbers all reset
            listBox1.Items.Clear();
            winningNumber1.Text = "";
            winningNumber2.Text = "";
            winningNumber3.Text = "";

            int winningNumber11 = 0;
            int winningNumber22 = 0;
            int winningNumber33 = 0;


            //These are my validaters and parse to changeover the numbers
            if (int.TryParse(myNumber1.Text, out winningNumber11))
            {
            }
            else
            {  
                MessageBox.Show("Please Enter A Valid Number In Box 1");
                return;
            }

            if (int.TryParse(myNumber2.Text, out winningNumber22))
            {
            }
            else
            { 
                MessageBox.Show("Please Enter A Valid Number In Box 2");
                return;
            }

            if (int.TryParse(myNumber3.Text, out winningNumber33))
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Number In Box 3");
                return;
            }


            
            decimal numberOfAttempts = 0;
            Random myRandomNumberGenerator = new Random();
            string winningNumber ;
            string matchNumbers;
            // this is the start of my loop i am not 100% sure if which you wanted us to use but i found this to be the 
            //easiest one to use.
            do
            {
                numberOfAttempts++;

                int myRandomNumber1 = myRandomNumberGenerator.Next(0, 10);
                int myRandomNumber2 = myRandomNumberGenerator.Next(0, 10);
                int myRandomNumber3 = myRandomNumberGenerator.Next(0, 10);
                winningNumber = winningNumber11 + "" + winningNumber22 + "" + winningNumber33;
                matchNumbers = myRandomNumber1 + "" + myRandomNumber2 + "" + myRandomNumber3;

                if (winningNumber == matchNumbers)
                {
                }

                if (myRandomNumber1 == winningNumber11)
                {
                    winningNumber1.Text = myRandomNumber1.ToString("");
                    winningNumber1.BackColor = Color.Green;
                }
                else
                {
                     winningNumber1.Text = myRandomNumber1.ToString("");
                     winningNumber1.BackColor = Color.LightGray;
                }
                if (myRandomNumber2 == winningNumber22)
                {
                    winningNumber2.Text = myRandomNumber2.ToString("");
                    winningNumber2.BackColor = Color.Green;
                }
                else
                {
                    winningNumber2.Text = myRandomNumber2.ToString("");
                    winningNumber2.BackColor = Color.LightGray;
                }
                if (myRandomNumber3 == winningNumber33)
                {
                    winningNumber3.Text = myRandomNumber3.ToString("");
                    winningNumber3.BackColor = Color.Green;
                }
                else
                {
                      winningNumber3.Text = myRandomNumber3.ToString("");
                      winningNumber3.BackColor = Color.LightGray;
                }


                attempts.Text = numberOfAttempts.ToString("");

                cashPrize.Text = "500 Smackers";

                listBox1.Items.Add("Attempt Number " + numberOfAttempts + " " + "Winning Numbers!!!" + " " + matchNumbers);
            }
            //this is so the loop ends when the numbers match or it reaches 1000 attempts
            while (numberOfAttempts < 1000 && winningNumber != matchNumbers);
            //this is so that a message box pops up when there is no match
            if (winningNumber != matchNumbers)
            {
                MessageBox.Show  ("No Winning Number In 1000 Attempts");
            }

             
           
        }
    }
}
