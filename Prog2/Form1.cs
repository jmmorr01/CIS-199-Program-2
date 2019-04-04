// Grading ID C9865
// Program 2
// Due March 9th
// Section 75
// Description:
// This Program allows you to enter your Last name and using radio buttons specify your class standing and based on this
// it will produce output that will tell you the time and date at which you can first register for the Fall 2017 semester.    
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e) // Button that takes the user data to determine the registration time for the user
        {
            string lastName; // Variable to hold the last name string the user inputs in the textbox on the form.
            char lastNameFirstLetter; // Variable to hold the first letter that is taken from the lastName string.
            string dateOutput; //Variable used to hold and then display the day the user can register. 
            string timeOutput = "placeholder"; // Variable used to hold and then display the time the user can register.

            const string FIRST_DAY = "March 29th"; // Constant that has string for first day of registration. 
            const string SECOND_DAY = "March 30th"; // Constant that has string for second day of registration. 
            const string THIRD_DAY = "March 31st"; // Constant that has string for third day of registration. 
            const string FOURTH_DAY = "April 3rd"; // Constant that has string for fourth day of registration. 
            const string FIFTH_DAY = "April 4th"; // Constant that has string for fifth day of registration. 
            const string SIXTH_DAY = "April 5th"; // Constant that has string for sixth day of registration. 

            const string TIME1 = "8:30 AM"; // Constant that has string for first time of registration. 
            const string TIME2 = "10:00 AM"; // Constant that has string for second time of registration. 
            const string TIME3 = "11:30 AM"; // Constant that has string for third time of registration. 
            const string TIME4 = "2:00 PM"; // Constant that has string for fourth time of registration. 
            const string TIME5 = "4:00 PM"; // Constant that has string for fifth time of registration. 

            if (lastNameInput.Text.Length > 0) // Checks to see if the user actually put something into the textbox.
            {
                lastName = lastNameInput.Text; // This block takes the string entered into the textbox and capitalizes it and extracts the first character from the string. 
                lastName = lastName.ToUpper();
                lastNameFirstLetter = lastName[0];

                if (char.IsLetter(lastNameFirstLetter)) // Checks to make sure that the first character in the string is a letter.
                {
                    if ((seniorRadio.Checked) || (juniorRadio.Checked)) // Checks to see if either the senior or junior radio button is checked. 
                    {
                        if (seniorRadio.Checked) // This block determines that if they are a senior, assign first day and if they are a junior assign the second day.
                            dateOutput = FIRST_DAY;
                        else dateOutput = SECOND_DAY;

                        if (lastNameFirstLetter <= 'D') // Because times based on last name are the same for senior/junior, this block determines times for each grouping of letters for both seniors and juniors. 
                            timeOutput = TIME3;
                        else if (lastNameFirstLetter <= 'I')
                            timeOutput = TIME4;
                        else if (lastNameFirstLetter <= 'J')
                            timeOutput = TIME5;
                        else if (lastNameFirstLetter <= 'S')
                            timeOutput = TIME1;
                        else timeOutput = TIME2;
                    }
                    else // If not a senior/junior, they must be a sophomore/freshman
                    {
                        if (sophomoreRadio.Checked) // Checks to see if they are a sophomore
                        {
                            if ((lastNameFirstLetter <= 'B') || (lastNameFirstLetter >= 'P')) // Assigns letters A-B and P-Z to the third day, and all other letters to the fourth day.
                                dateOutput = THIRD_DAY;
                            else dateOutput = FOURTH_DAY;
                        }
                        else // Must be a freshman at this point.
                        {
                            if ((lastNameFirstLetter <= 'B') || (lastNameFirstLetter >= 'P')) // Assigns letters A-B and P-Z to the fifth day, and all other letters to the sixth day.
                                dateOutput = FIFTH_DAY;
                            else dateOutput = SIXTH_DAY;
                        }

                        if ((lastNameFirstLetter == 'A') || (lastNameFirstLetter == 'B') || (lastNameFirstLetter == 'M') || (lastNameFirstLetter == 'O')) // Because times based on last name are the same for sophomore/freshman
                            timeOutput = TIME5;                                                                                                           // This block assigns A-B and M-O to time 5, C-D and P-Q to time 1,
                        else if ((lastNameFirstLetter == 'C') || (lastNameFirstLetter == 'D') || (lastNameFirstLetter == 'P') || (lastNameFirstLetter == 'Q')) // E-F and R-S to time 2, G-I and T-V to time 4, and J-L and W-Z to time 4.
                            timeOutput = TIME1;
                        else if ((lastNameFirstLetter == 'E') || (lastNameFirstLetter == 'F') || (lastNameFirstLetter == 'R') || (lastNameFirstLetter == 'S'))
                            timeOutput = TIME2;
                        else if ((lastNameFirstLetter == 'G') || (lastNameFirstLetter == 'I') || (lastNameFirstLetter == 'T') || (lastNameFirstLetter == 'V'))
                            timeOutput = TIME3;
                        else if ((lastNameFirstLetter == 'J') || (lastNameFirstLetter == 'L') || (lastNameFirstLetter == 'W') || (lastNameFirstLetter == 'Z'))
                            timeOutput = TIME4;
                    }
                    outputLabel.Text = timeOutput + " on " + dateOutput; // This takes the time and date determined above and creates an output that looks like "timeOutput on dateOutput" ex. "4:00PM on March 31st".  

                }

                else
                {
                    MessageBox.Show("Enter Valid Last Name"); // Tells the user they entered a string that did not contain a letter as the first character.
                }
            }
            else
            {
                MessageBox.Show("Last Name TextBox Empty, Enter Last Name"); // Tells the user that the last name textbox is empty.
            }
        }
    }
}
