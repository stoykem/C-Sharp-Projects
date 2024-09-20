//Name: Miguel Stoyke
//App Name: Car Service Shop (Form1.cs)
//Date Created: October 29th, 2023
//Last Modified: November 5th, 2023
//Description: Tracks car services including customer/car details, and their selected services along with their costs. This is the main form for the app

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment3_MiguelStoyke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Allows additional access keys to be used, and adds the KeyUp method to the event handler
            this.KeyPreview = true;
            this.KeyUp += Form1_KeyUp;

            //Attempts to load the event handler that processes the ListView header values
            try
            {
                this.Load += new EventHandler(SummaryProcess);
            }
            catch (Exception e)
            {
                Cost.Text = "Error: " + e.Message;
            }
        }

        //ClearInputs() method - generic call to set input fields back to default
        private void ClearInputs()
        {
            FNameText.Focus();

            FNameText.Text = "";
            LNameText.Text = "";
            PhoneText.Text = "";
            ModelText.Text = "";
            CostText.Text = "";
            ColourText.Text = "";

            EOilChange.Checked = false;
            TOilChange.Checked = false;
            AFilterChange.Checked = false;

            //Reset dropdowns
            MakeDrop.SelectedIndex = -1;
            YearDrop.SelectedIndex = -1;
        }

        //SummaryProcess() method - displays listview header as long as handler is not null
        private void SummaryProcess(object? sender, EventArgs e)
        {
            Summary.View = View.Details;
            Summary.Columns.Add("NO", 50);
            Summary.Columns.Add("First Name", 90);
            Summary.Columns.Add("Last Name", 90);
            Summary.Columns.Add("Phone", 100);
            Summary.Columns.Add("Make", 100);
            Summary.Columns.Add("Model", 90);
            Summary.Columns.Add("Year", 90);
            Summary.Columns.Add("Colour", 90);
            Summary.Columns.Add("Oil Change", 90);
            Summary.Columns.Add("Transmission Oil Change", 180);
            Summary.Columns.Add("Air Filter Change", 150);
        }

        //SummaryGenerate() method - called to generate a new service record
        //in the list view of type CarService based on CarService.cs
        private void SummaryGenerate()
        {
            //Attempts to create a new CarService object to populate a list view record.
            //handles exception errors accordingly
            try
            {
                //Sets CarService variables and trims white space
                string firstName = FNameText.Text.Trim();
                string lastName = LNameText.Text.Trim();
                string phoneNum = PhoneText.Text.Trim();
                string carModel = ModelText.Text.Trim();
                string carColour = ColourText.Text.Trim();
                string carMake = MakeDrop.Text.Trim();
                string carYear = YearDrop.Text.Trim();
                long phoneNumber = 0; //long created to validate numeric phone number
                double serviceCost = 0;

                //Validation

                //Checks if names have been provided
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    throw new Exception("Must enter a first and last name.");
                }

                //Parses phone number as long to determine if numeric, and within the allowed range
                else if (!long.TryParse(phoneNum, out phoneNumber) || phoneNum.Length > 10 || phoneNum.Length < 10)
                {
                    throw new Exception("Phone number must be numeric, and have ten digits.");
                }

                //Checks if a make and year have been selected
                else if (MakeDrop.SelectedIndex <= -1 || YearDrop.SelectedIndex <= -1)
                {
                    throw new Exception("Must select car make and year.");
                }

                //Checks if a model and colour have been selected
                else if (string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(carColour))
                {
                    throw new Exception("Must select car model and colour.");
                }

                //Gets here once all conditions are met to make a CarService object, and add a record into the listview
                else
                {
                    //Creates unique ID using a counter variable
                    int no = CarService.serviceCount;

                    //Checks which services have been selected and adds them to the total cost
                    if (EOilChange.Checked == true)
                    {
                        serviceCost += (CarService.EOIL_CHANGE_COST * CarService.TAX);
                    }
                    if (TOilChange.Checked == true)
                    {
                        serviceCost += (CarService.TOIL_CHANGE_COST * CarService.TAX);
                    }
                    if (AFilterChange.Checked == true)
                    {
                        serviceCost += (CarService.FILTER_CHANGE_COST * CarService.TAX);
                    }

                    //Creates the object using the determined variables
                    CarService newService = new CarService(
                        no,
                        firstName,
                        lastName,
                        phoneNumber.ToString(),
                        carMake,
                        carModel,
                        carColour,
                        int.Parse(carYear),
                        EOilChange.Checked,
                        TOilChange.Checked,
                        AFilterChange.Checked,
                        serviceCost
                        );

                    //Converts the data from the CarService object into a displayable listviewitem array
                    ListViewItem customer = new ListViewItem(new string[] {
                            newService.Count.ToString(),
                            newService.firstName,
                            newService.lastName,
                            newService.phoneNumber,
                            newService.make,
                            newService.model,
                            newService.year.ToString(),
                            newService.colour,
                            //If a service is selected, the calculation is displayed. If it is not selected, the field will populate N/A as default
                            (EOilChange.Checked ? $"{(CarService.EOIL_CHANGE_COST * CarService.TAX):C2}" : "N/A"),
                            (TOilChange.Checked ? $"{(CarService.TOIL_CHANGE_COST * CarService.TAX):C2}" : "N/A"),
                            (AFilterChange.Checked ? $"{(CarService.FILTER_CHANGE_COST * CarService.TAX):C2}" : "N/A")
                        });

                    //Displays the total cost rounded to two decimal places
                    CostText.Text = $"{serviceCost:C2}";

                    //Finally, it adds the input data to the listview
                    Summary.Items.Add(customer);

                    //Clear the input values if validated
                    ClearInputs();
                }
            }
            catch (Exception e)
            {
                //Display appropriate error message
                CostText.Text = e.Message;
            }
        }

        //AddButton method - generates a service when add is clicked, then clears inputs
        private void AddButton_Click(object sender, EventArgs e)
        {
            SummaryGenerate(); //creates object and populates listview
        }

        //NewButton method - clears the inputs back to default
        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        //RemoveAllButton method - clears the inputs and the listview back to default
        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            ClearInputs();
            Summary.Items.Clear();
        }

        //RemoveButton method - removes the selected service from the listview
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Attempts to retrieve a service from the listview. Handles exception accordingly
            try
            {
                //if it finds a valid selected service
                if (Summary.SelectedItems.Count > 0)
                {
                    //Sets the selected area to an integer variable index value
                    int index = Summary.SelectedItems[0].Index;

                    //Removes the row/service based on the index set above
                    Summary.Items.RemoveAt(index);

                    //Sets a counter to determine how many services are currently in the listview
                    int counter = Summary.Items.Count;

                    //(had to do some research online here) Iterates through all of the services currently in the list view
                    //It determines the correct ID based on the service index that has been removed
                    for (int i = index; i < counter; i++)
                    {
                        //Retrieves value from selected subitem, and decrements it by 1 to display an appropriate ID
                        int newCount = int.Parse(Summary.Items[i].SubItems[0].Text) - 1;

                        //Updates the ID based on numerical order after a service is removed
                        Summary.Items[i].SubItems[0].Text = newCount.ToString();
                    }

                    //Decrements the actual serviceCount to avoid duplicates/non-consistent ID's
                    CarService.serviceCount--;

                    ClearInputs();
                }
                else
                {
                    CostText.Text = "No service selected to remove";
                }
            }
            catch (Exception ex)
            {
                CostText.Text = ex.Message;
            }
        }

        //Exit application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Update button method - processes input to update an existing service
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Checks if there are items in the list view
            if (Summary.SelectedItems.Count > 0)
            {
                //Attempts to process update and handles exceptions
                try
                {
                    //Sets a default item to determine the item clicked
                    ListViewItem selectedItem = Summary.SelectedItems[0];

                    //Sets the index to the selected row
                    int index = Summary.Items.IndexOf(selectedItem);

                    //Update the selected row in the list view by setting the sub-items
                    //of the selected row to their respective input field
                    selectedItem.SubItems[1].Text = FNameText.Text; // First Name
                    selectedItem.SubItems[2].Text = LNameText.Text; // Last Name
                    selectedItem.SubItems[3].Text = PhoneText.Text; // Phone
                    selectedItem.SubItems[4].Text = MakeDrop.Text; // Make
                    selectedItem.SubItems[5].Text = ModelText.Text; // Model
                    selectedItem.SubItems[6].Text = YearDrop.Text; // Year
                    selectedItem.SubItems[7].Text = ColourText.Text; // Colour

                    //Decides which checkboxes are true based on the value of the subitem
                    selectedItem.SubItems[8].Text = (EOilChange.Checked ? $"{(CarService.EOIL_CHANGE_COST * CarService.TAX):C2}" : "N/A");
                    selectedItem.SubItems[9].Text = (TOilChange.Checked ? $"{(CarService.TOIL_CHANGE_COST * CarService.TAX):C2}" : "N/A");
                    selectedItem.SubItems[10].Text = (AFilterChange.Checked ? $"{(CarService.FILTER_CHANGE_COST * CarService.TAX):C2}" : "N/A");

                    //Calculate and display the total cost of the updated service
                    double serviceCost = 0;

                    if (EOilChange.Checked == true)
                    {
                        serviceCost += (CarService.EOIL_CHANGE_COST * CarService.TAX);
                    }
                    if (TOilChange.Checked == true)
                    {
                        serviceCost += (CarService.TOIL_CHANGE_COST * CarService.TAX);
                    }
                    if (AFilterChange.Checked == true)
                    {
                        serviceCost += (CarService.FILTER_CHANGE_COST * CarService.TAX);
                    }

                    CostText.Text = $"{serviceCost:C2}";

                    //Update the listview item at the specific index
                    Summary.Items[index] = selectedItem;
                }
                catch (Exception ex)
                {
                    CostText.Text = ex.Message;
                }
            }
            else
            {
                CostText.Text = "No service selected to update";
            }
        }

        //List View SelectedIndexChanged method - retrieves values of the selected index of the listview
        private void Summary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Summary.SelectedItems.Count > 0)
            {
                try
                {
                    //Displays the corresponding values of selected service back into input fields
                    ListViewItem selectedItem = Summary.SelectedItems[0];
                    FNameText.Text = selectedItem.SubItems[1].Text; // First Name
                    LNameText.Text = selectedItem.SubItems[2].Text; // Last Name
                    PhoneText.Text = selectedItem.SubItems[3].Text; // Phone
                    MakeDrop.Text = selectedItem.SubItems[4].Text; // Make
                    ModelText.Text = selectedItem.SubItems[5].Text; // Model
                    YearDrop.Text = selectedItem.SubItems[6].Text; // Year
                    ColourText.Text = selectedItem.SubItems[7].Text; // Colour

                    //Decides which checkboxes are true based on the value of the subitem
                    EOilChange.Checked = selectedItem.SubItems[8].Text != "N/A";
                    TOilChange.Checked = selectedItem.SubItems[9].Text != "N/A";
                    AFilterChange.Checked = selectedItem.SubItems[10].Text != "N/A";

                    string firstName = FNameText.Text.Trim();
                    string lastName = LNameText.Text.Trim();
                    string phoneNum = PhoneText.Text.Trim();
                    string carModel = ModelText.Text.Trim();
                    string carColour = ColourText.Text.Trim();
                    string carMake = MakeDrop.Text.Trim();
                    string carYear = YearDrop.Text.Trim();
                    long phoneNumber = 0;
                    double serviceCost = 0;

                    //Same validation as AddButton
                    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                    {
                        throw new Exception("Must enter a first and last name.");
                    }

                    else if (!long.TryParse(phoneNum, out phoneNumber) || phoneNum.Length > 10 || phoneNum.Length < 10)
                    {
                        throw new Exception("Phone number must be numeric, and have ten digits.");
                    }

                    else if (MakeDrop.SelectedIndex <= -1 || YearDrop.SelectedIndex <= -1)
                    {
                        throw new Exception("Must select car make and year.");
                    }

                    else if (string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(carColour))
                    {
                        throw new Exception("Must select car model and colour.");
                    }

                    //Checks which services are true in the selected service. Adjusts checkboxes accordingly
                    if (EOilChange.Checked == true)
                    {
                        serviceCost += (CarService.EOIL_CHANGE_COST * CarService.TAX);
                    }
                    if (TOilChange.Checked == true)
                    {
                        serviceCost += (CarService.TOIL_CHANGE_COST * CarService.TAX);
                    }
                    if (AFilterChange.Checked == true)
                    {
                        serviceCost += (CarService.FILTER_CHANGE_COST * CarService.TAX);
                    }

                    //Display the current cost of the selected service
                    CostText.Text = $"{serviceCost:C2}";
                }
                catch (Exception ex)
                {
                    CostText.Text = ex.Message;
                }
            }
        }

        //KeyUp method - Allows events to be accessed using specified keys
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //If escape key is clicked, trigger New button
            if (e.KeyCode == Keys.Escape)
            {
                NewButton.PerformClick();
            }

            //If enter key is clicked, trigger Add button
            else if (e.KeyCode == Keys.Enter)
            {
                AddButton.PerformClick();
            }
        }
    }
}