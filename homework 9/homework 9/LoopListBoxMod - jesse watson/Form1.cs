using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopListBoxMod___jesse_watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal startYear = 0;
            decimal endYear = 0;

            

            if (decimal.TryParse(startYears1.Text, out startYear))
            {
            }
            else
            {
                MessageBox.Show("Please enter a valid start year");
                return;
            }

            if (decimal.TryParse(endYears1.Text, out endYear))
            {
            }
            else
            {
                MessageBox.Show("Please enter a valid start year");
                return;
            }
           
            decimal presidentYear = 0;
            decimal censusYear = 0;
            string myYear = "";
            listBox1.Items.Clear();

            for (decimal year = startYear; year <= endYear; year++)
            {
                if (president.Checked)
                {
                    presidentYear = year % 4;
                    if (presidentYear == 0)
                    {
                        myYear = year.ToString() + " " + "Presidential Elections";
                    }
                    else
                    {
                        myYear = year.ToString();
                    } 
                }
                else
                {
                    myYear = year.ToString();
                }
                if (census.Checked)
                    {
                        censusYear = year % 10;
                        if (censusYear == 0)
                        {
                            myYear = year.ToString() + " " + "Census Year";
                        }
                        else
                        {
                            myYear = year.ToString();
                        }
                    }
                if (president.Checked && census.Checked)
                {
                    censusYear = year % 10;
                    presidentYear = year % 4;
                    presidentYear = year % 4;

                    if (presidentYear == 0)
                    {
                        myYear = year.ToString() + " " + "Presidential Elections";
                    }
                    if (censusYear == 0)
                    {
                        myYear = year.ToString() + " " + "Census Year";
                    }
                    if (censusYear == 0 && presidentYear == 0)
                    { myYear = year.ToString() + " " + "Presidential Elections" + " " + "Census Year";
                    }

                }
               
                listBox1.Items.Add(myYear); 
            }




        } 
    }
}
