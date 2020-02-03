//N5284
//Lab 7
//March 24, 2019
//CIS 199-75
//This program takes the amount of words typed a minute (input by user) and outputs a predefined letter grade

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        //When the "Calculate" button is pressed the following happens:
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            char[] grade = new char[] { 'F', 'D', 'C', 'B', 'A' };  //Array of letter grades
            int[] words = new int[] { 0, 16, 31, 51, 76 };          //Array of the thresholds of words per minute
            int index = words.Length - 1;                           //The length of words per minute array used as an indexing value
            int minValue = 0;                                       //The minimum value used in the program
            int wordsPerMinute;                                     //The users input for words typed in a minute
            bool found = false;                                     //Boolean Value to check if match was found

            if (Int32.TryParse(inWordsPerMinuteTxt.Text, out wordsPerMinute) && wordsPerMinute >= minValue)
            {
                while (index >= minValue && !found)
                {
                    if (wordsPerMinute >= words[index])
                        found = true;
                    else
                        --index;
                }
                if (found)
                    outGradeLbl.Text = $"{grade[index]}";
            }

            else
            {
                MessageBox.Show("Input invalid. Try Again");
            }
        }

        //If the "Clear" button is pressed the following happens:
        private void clearBtn_Click(object sender, EventArgs e)
        {
            inWordsPerMinuteTxt.Text = $"";
            outGradeLbl.Text = $"";
        }
    }
}
