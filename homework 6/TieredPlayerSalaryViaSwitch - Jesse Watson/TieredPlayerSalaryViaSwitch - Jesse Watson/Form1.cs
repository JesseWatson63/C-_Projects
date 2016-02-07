using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jesse Watson
//10-18-2013
//256777
//Purpose is to create a program that shows you athletes are paid way to much.
namespace TieredPlayerSalaryViaIF___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal salaryTotal = 0;
        const decimal allStar = .10m;
        const decimal bonusMvp = .10m;
        decimal salaryFinal = 0;
        decimal hits1 = 0;
        decimal tempHitCount;
        int tier = 0;
        private void calculateButton_Click(object sender, EventArgs e)
        {//This is for the players combined name
            try
            {
                playersName.Text = firstName.Text + " " + lastName.Text;
            //End of players combined name
       
           //start of salary calculator
               
                
                hits1 = decimal.Parse(hits.Text);
        //start of the if else to calculate tier
                tier = 0;

                if (hits1 > 0 && hits1 <= 49)
                {
                    tier = 1;
                }
                else if (hits1 >= 50 && hits1 <= 99)
                {
                    tier = 2;
                }
                else if (hits1 >= 100 && hits1 <= 149)
                {
                    tier = 3;
                }
                else
                {
                    tier = 4;
                }

        //end of if else which will allow the program to determine a tier to use
        //Start of constant salarys
                decimal salaryToUse = 0;
                const decimal salary1 = 5000;
                const decimal salary2 = 7500;
                const decimal salary3 = 10000;
                const decimal salary4 = 12500;
        //end of constant salarys
        //Start of switch "this was very difficult"
                switch (tier)
                {
                    case 1:
                        salaryToUse = salary1;
                        break;
                    case 2:
                        salaryToUse = salary2;
                        break;
                    case 3:
                        salaryToUse = salary3;
                        break;
                    case 4:
                        salaryToUse = salary4;
                        break;
                    default:
                        return;
                }
         //End of switch

               
                salaryFinal = (hits1 * salaryToUse);



                if (mvpBonus.Checked && allStarBonus.Checked)
                {
                    salaryTotal = salaryFinal + ((salaryFinal * bonusMvp) + (salaryFinal * allStar));
                playersName.Text = (firstName.Text + " " + lastName.Text + " " + "MVP" + " " + "and " + " " + "All Star"); }

                else if(mvpBonus.Checked)
                { salaryTotal = salaryFinal + (salaryFinal * bonusMvp); 
                     playersName.Text = (firstName.Text + " " + lastName.Text + " " + "MVP");}
                 else if (allStarBonus.Checked)
                {
                    salaryTotal = salaryFinal + +(salaryFinal * allStar);
                    playersName.Text = (firstName.Text + " " + lastName.Text + " " + "All Star"); }
                else
                { salaryTotal = salaryFinal; }
                 playersSalary.Text = salaryTotal.ToString("c");}
            catch {
                MessageBox.Show("Please Enter A Valid Name and Hit Amount");}

           //This is for highest paid hitter
            if (hits1 > tempHitCount)
            {
                
                tempHitCount = hits1;
                bestPlayer.Text = playersName.Text;
                salary.Text = playersSalary.Text;
                totalHits.Text = hits.Text;
                tierPay.Text = tier.ToString();  
            
            
            }

            //End of highest paid hitter
           }

        private void clearButton_Click(object sender, EventArgs e)
        {
            firstName.Text = "";
            lastName.Text = "";
            hits.Text = "";
            playersName.Text = "";
            playersSalary.Text = "";
            salary.Text = "";
            totalHits.Text = "";
            bestPlayer.Text = "";
            tierPay.Text = "";
            mvpBonus.Checked = false;
            allStarBonus.Checked = false;
        }
        
           }
}
