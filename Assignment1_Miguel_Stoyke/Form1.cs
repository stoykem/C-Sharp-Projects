//Name: Miguel Stoyke
//App Name: Simple Calculations Form
//Date Created: September 25th, 2023
//Last Modified: October 1st, 2023
//Description: This app allows the user to perform a calculation using 7 inputted numbers and calculating their average.
//The average will be based on whole number inputs

namespace Assignment1_Miguel_Stoyke
{
    public partial class Form1 : Form
    {
        //Variables
        private int[] weeklySales = new int[7]; //Array of 7 sales inputs
        int maxInt = 2147483647;
        int numInput = 0;
        int numCounter = 0;
        float numSum = 0;
        float numAverage = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AverageGameSales_TextChanged(object sender, EventArgs e)
        {
            //
        }

        //Enter button actions
        private void EnterButton_Click(object sender, EventArgs e)
        {
            //Bring cursor to the input box
            InputBox.Focus();

            //Read initial user input and check if a value has been entered yet
            string userInput = InputBox.Text;
            if (string.IsNullOrWhiteSpace(userInput))
            {
                AverageGameSales.Text = "Average Video Game Sales: Value cannot be empty.";
            }
            else
            {
                //Calls the method to process calculations if a value has been entered for further validation
                WeeklyInputsProcessing();
            }
        }

        //Reset button actions
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Re-enable input box and enter button when form is reset
            InputBox.ReadOnly = false;
            EnterButton.Enabled = true;

            //Reset text fields for the input box, day # counter, and the output box back to default
            InputBox.Text = "";
            DayNum.Text = "Day #";
            AverageGameSales.Text = "Average Video Game Sales: $";

            //Clear the list box of inputs
            SalesList.Items.Clear();

            //Reset the counter and sum variables to ensure values are always correct
            numCounter = 0;
            numSum = 0;
            InputBox.Focus();
        }

        //Methods -----------------------------------------------

        //Method for numeric and range validation, and calculating the average of all 7 inputs
        private void WeeklyInputsProcessing()
        {
            //Check if the input can be parsed as an integer
            if (int.TryParse(InputBox.Text, out numInput))
            {
                //If it is an integer, check if its between 0 and the maximum integer value
                if (numInput >= 0 && numInput <= maxInt)
                {
                    //If there are less than 7 inputs typed in, it will keep asking for whole numbers
                    if (numCounter < 7)
                    {
                        //Reset output box text so the error message clears appropriately
                        AverageGameSales.Text = "Average Video Game Sales: $";

                        //Modifying the correct index of the array
                        weeklySales[numCounter] = numInput;

                        //Add each value to array indices
                        SalesList.Items.Add(numInput);

                        //Iterate and display what day the user is inputting sales for
                        DayNum.Text = "Day # " + (numCounter + 1);

                        //Clear the input box, add to the counter, and add to the total sum
                        InputBox.Clear();
                        numCounter++;
                        numSum += numInput;

                        //If 7 inputs have been recieved
                        if (numCounter == 7)
                        {
                            //Input box and enter button are disabled until form is reset
                            InputBox.ReadOnly = true;
                            EnterButton.Enabled = false;

                            //Focus cursor to the reset button
                            ResetButton.Focus();

                            //Calculate average by dividing the total sum of all numbers, by the length of the array (7) parsed as a float for a decimal average.
                            numAverage = numSum / (float)weeklySales.Length;

                            //Modify output box to show the final average over the 7 days of sales
                            AverageGameSales.Text = "Average Video Game Sales: $" + numAverage.ToString("F2");
                        }
                    }
                }
                else
                {
                    //Range validation error
                    AverageGameSales.Text = "Average Video Game Sales: Must be between 0 and 2147483647.";
                    InputBox.Focus();
                }
            }
            else
            {
                //Numeric and/or whole number error
                AverageGameSales.Text = "Average Video Game Sales: Must be numeric and a whole number.";
                InputBox.Focus();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Close Application
            Close();
        }
    }
}