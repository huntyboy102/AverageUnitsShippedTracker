using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    /*
     * Name: Hunter L
     * Date: 2021-01-21
     * Desc: This program accepts entries of items that were shipped for 7 days. It adds all of the entries to one textbox
     * and determines the average amount of items shipped per day. This program has validation so that a user cannot go over or under the specified amount.
     */
    public partial class Form1 : Form
    {
        // Declare class level variables.
        int currentDay = 1;
        int runningTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the button is clicked do all of this stuff!
        /// Append the entries to the running total text box.
        /// Add a day to the current day.
        /// Validate the number to see if it is whole and in between 0-5000.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnterClick(object sender, EventArgs e)
        {
            // Declare variables and constants.
            const int MinUnits = 0;
            const int MaxUnits = 5000;
            const int MaxDays = 7;
            int lastEntry;

            // Validate the number entered is whole.
            if (int.TryParse(textboxShippedQuantityEntry.Text, out lastEntry))
            {
                // Validate the number entered is between 0 and 5000.
                if (lastEntry >= MinUnits && lastEntry <= MaxUnits)
                {
                    // The data has been validated.
                    // Add the last entry to the running total.
                    runningTotal += lastEntry;
                    textboxRunningTotal.Text += lastEntry + "\r\n";
                    // Increate current day by 1.
                    currentDay++;

                    textboxShippedQuantityEntry.Clear();

                    if (currentDay > MaxDays)
                    {
                        // Determine the average of shipments per day.
                        double averageUnits;
                        averageUnits = (double)runningTotal / (double)MaxDays;
                        // Output the result.
                        labelAverageShipped.Text = "Average per day: " + Math.Round(averageUnits, 2);
                        // Disable the controls.
                        textboxShippedQuantityEntry.Enabled = false;
                        buttonEnter.Enabled = false;
                        // Set focus to the reset button.
                        buttonReset.Focus();
                    }
                    else
                    {
                        // Display the current day.
                        labelDay.Text = "Day " + currentDay;
                        // Set the focus to the new entry
                        textboxShippedQuantityEntry.Focus();
                    }
                }
                else
                {
                    // The value entered is less than 0 or greater than 5000.
                    MessageBox.Show("Enter a value between " + MinUnits + " and " + MaxUnits + ".", "Woah!");
                    textboxShippedQuantityEntry.SelectAll();
                    textboxShippedQuantityEntry.Focus();
                }
            }
            else
            {
                // The value entered is not a whole number.
                MessageBox.Show("Enter a whole number", "Woah!");
                textboxShippedQuantityEntry.SelectAll();
                textboxShippedQuantityEntry.Focus();
            }



        }

        /// <summary>
        /// Reset the form to its untouched design.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonResetClick(object sender, EventArgs e)
        {
            // Clear all input and output fields.
            textboxShippedQuantityEntry.Clear();
            textboxRunningTotal.Clear();
            labelAverageShipped.Text = String.Empty;

            // Reset the class-level variables.
            currentDay = 1;
            runningTotal = 0;

            // Enable all controls that were disabled when user finished.
            textboxShippedQuantityEntry.Enabled = true;
            buttonEnter.Enabled = true;

            // Set the focus to the entry field.
            textboxShippedQuantityEntry.Focus();
        }

        /// <summary>
        /// Closes the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
