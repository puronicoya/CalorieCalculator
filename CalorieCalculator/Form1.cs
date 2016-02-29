/************************************************
 *Programmer: Allan Carranza                    *
 *Date: October 12, 2012                        *
 *Purpose:This program calculates               *
 *a persons recommended calorie intake          *
 *based on weight and activity level.           *
 *History: Added try-catch for numeric          *
 *data on October 21, 2012                      *
 ************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalorieCalculator
{
    public partial class frmHealthClub : Form
    {
        public frmHealthClub()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declaring variables for validation
            string errorMessage;
            errorMessage = "";
            int intGenderFactor;
            intGenderFactor = 0;
            double weight1;
            weight1 = 0;
            double weight2;
            weight2 = 0;
            double weightResult;
            weightResult = 0;
            double dailyCalories;
            dailyCalories = 0;
            double weightPounds;
            weightPounds = 0;


            //checking if the first & last name is empty.
            if (txtFirstName.Text == "" && txtLastName.Text == "")
            {
                errorMessage += "Please Enter First Name and Last Name.";
            }
            else if (txtFirstName.Text == "")
            {
                errorMessage += "Please Enter First Name.";
            }
            else if (txtLastName.Text == "")
            {
                errorMessage += "Please Enter Last Name.";
            }

            //Checking if gender is selected
            if (!radMale.Checked && !radFemale.Checked)
            {
                errorMessage += "\nPlease select your gender.";
            }

            //Checking if activity level is checked
            if (!radActive.Checked && !radInactive.Checked)
            {
                errorMessage += "\nPlease select your activity level.";
            }
          
            /* checking to make sure that a gender and activity level is checked
            for Gender Factor to be determined */

            if (radMale.Checked && radActive.Checked)
            {
                intGenderFactor = 15;
            }
            else if (radMale.Checked && radInactive.Checked)
            {
                intGenderFactor = 13;
            }
            else if (radFemale.Checked && radActive.Checked)
            {
                intGenderFactor = 12;
            }
            else if (radFemale.Checked && radInactive.Checked)
            {
                intGenderFactor = 10;
            }

            /*checking if weight in lbs or kg's has text. if one field is empty
            the conversion will be calculated then applied to that field */

                if (txtWeightLbs.Text == "" && txtWeightKgs.Text == "")
                {
                    errorMessage += "\nPlease enter your weight in lbs or Kg's.";
                }
                else if (txtWeightLbs.Text == "")
                {
                    try
                    {
                        weight1 = Convert.ToDouble(txtWeightKgs.Text);
                        weightResult = weight1 * 2.2;
                        txtWeightLbs.Text = weightResult.ToString();
                    }
                    catch
                    {
                        errorMessage += "\nEnter a valid number in Kg field.";
                    }
                }
                else if (txtWeightKgs.Text == "")
                {
                    try
                    {
                        weight2 = Convert.ToDouble(txtWeightLbs.Text);
                        weightResult = weight2 / 2.2;
                        txtWeightKgs.Text = weightResult.ToString();
                    }
                    catch
                    {
                        errorMessage += "\nEnter valid number in Lbs field.";
                    }
                }
                
            
            //This calculates total calories
            if (errorMessage == "")
            {
                weightPounds = Convert.ToDouble(txtWeightLbs.Text);
                dailyCalories = weightPounds * intGenderFactor;
                txtTotalDailyCalories.Text = dailyCalories.ToString();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This code clears the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtTotalDailyCalories.Text = "";
            txtWeightKgs.Text = "";
            txtWeightLbs.Text = "";
            radMale.Checked = false;
            radFemale.Checked = false;
            radActive.Checked = false;
            radInactive.Checked = false;

        }
    }
}
