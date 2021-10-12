using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Form1 : Form
    {
        int age;
        double hoursWorked;
        double normalHours;
        double overtimeHours;
        int numOne;
        int numTwo;
        int year;
        public Form1()
        {
            InitializeComponent();
        }

        private void driveButton_Click(object sender, EventArgs e)
        {
            /// Create an if statement to check age and display a 
            /// message stating "You can drive now" if age is 16. 
            /// If not 16 then display, "You are not 16".
            age = Convert.ToInt32(ageInput.Text);

            if (age >= 16)
            {
                driveOutput.Text = "You can Drive now";
            } else
            {
                driveOutput.Text = "No driving for you, you are not 16";
            }

        }

        private void ageButton_Click(object sender, EventArgs e)
        {
            /// Create a variable to hold a person's age. Then use 
            /// that variable to determine if the person is old 
            /// enough to vote. Display an appropriate message based
            /// on whether they can or can't vote            

            age = Convert.ToInt32(ageInput.Text);

            if (age >= 18)
            {
                voteOutput.Text = "You can vote";
            } else
            {
                voteOutput.Text = "You cannot vote";
            }
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines how many overtime 
            /// hours an employee has worked. Any hours over 40 is 
            /// considered overtime. Make sure that your output matches
            /// the sample output below exactly.
            ///
            /// Sample Output for 15 hours:
            /// You worked 15 hours
            /// 
            /// Sample output for 45 hours:
            /// You worked 40 hours plus 5 hours overtime
            /// 

            normalHours = 40;
            hoursWorked = Convert.ToInt32(hoursInput.Text);
            
            if (hoursWorked > normalHours)
            {
                overtimeHours = hoursWorked - normalHours;
                workOutput.Text = $"You worked {normalHours} hours and {overtimeHours} hours over time";
            } else if (hoursWorked <= normalHours)
            {
                workOutput.Text = $"You worked {hoursWorked} hours";
            }



        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines the max value 
            /// between 2 values inputted by the user. The output 
            /// should match the following:
            /// 
            /// Sample output for inputs 34, 12
            /// The max value is: 34
            /// 
            /// Sample output for inputs 22, 77
            /// The max value is: 77
            numOne = Convert.ToInt32(num1Input.Text);
            numTwo = Convert.ToInt32(num2Input.Text);

            if (numOne > numTwo)
            {
                maxOutput.Text = $"The Max value is: {numOne}";
            } else if (numOne < numTwo)
            {
                maxOutput.Text = $"The Max value is: {numTwo}";
            }

        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            /// Create a program that determines if an entered year
            /// is a leap year. The output should match the following:
            /// 
            /// Sample output for inputs 2002
            /// 2002 is not a leap year
            /// 
            /// Sample output for inputs 2016
            /// 2016 is a leap year

            // Can be divided by 100 and 400
            year = Convert.ToInt32(yearInput.Text);


            if (DateTime.IsLeapYear(year))
                {
                yearOutput.Text = $"{year} is a leap year";
                } else
            {
                yearOutput.Text = $"{year} is NOT a leap year";
            }
            
            
        }

        private void driveOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
