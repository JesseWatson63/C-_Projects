using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Jesse Watson
//11-25-2013
//256777
//The purpose of this program is so that i can input 5 student names and there grades and display them in one area

namespace ArrayOfStudents___Jesse_Watson  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Here are all my constants and things needed for storing information for the long run
        const int Const_Array_Students_Names = 5;
        string[] studentsNames = new string[Const_Array_Students_Names];
        int[] studentsGrades = new int[Const_Array_Students_Names];
        int studentNamesInfo = 0;
        int studentGradesInfo = 0;
        int i = 0;
        //this is the button click for entering information into the array
        private void button1_Click(object sender, EventArgs e)
        {
            int studentGrade = 0;
            int.TryParse(studentGradesTextBox.Text, out studentGrade);
            if ( studentGrade <= 100)
            {
                if (studentNamesInfo < 5)
                {
                    studentsNames[studentNamesInfo] = studentsNamesTextBox.Text;
                    studentNamesInfo++;
                    studentsGrades[studentGradesInfo] = studentGrade;
                    studentGradesInfo++;
                }
                else
                {
                    MessageBox.Show("Your Array Is Full Please Reset");
                }
                MessageBox.Show("Students Name-" + " " + studentsNamesTextBox.Text + " " + "Students Grade-" + " " + studentGrade + "%");
            }
            else
            {
                MessageBox.Show(" Please enter a grade of 100% or Lower.  There is no extended scale.");
            }
        }
        //this is the button click to display the array information into the label
        private void button2_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "";
            studentNamesInfo = 0;
            studentGradesInfo = 0;
            for ( i = 0; i < Const_Array_Students_Names; i++)
            {       
                    infoLabel.Text = infoLabel.Text + ("Students Name " + (studentsNames[i]) + " " + "Students Grade" + " " + studentsGrades[i]) + " \n";           
            }
            Array.Clear(studentsNames, 0, studentsNames.Length);
            Array.Clear(studentsGrades, 0, studentsGrades.Length);
        }
        //This is the clear button took a min 
        private void button3_Click(object sender, EventArgs e)
        {
            Array.Clear(studentsNames, 0, studentsNames.Length);
            Array.Clear(studentsGrades, 0, studentsGrades.Length);
            studentNamesInfo = 0;
            studentGradesInfo = 0;
            infoLabel.Text = "";
        }
    }
}
