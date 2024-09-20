//Name: Miguel Stoyke
//App Name: DC Registration App (Form1.cs)
//Date Created: November 26th, 2023
//Last Modified: December 4th, 2023
//Description: This app was developed for the purpose of Durham College staff to track and register eligible students into a mock college database run through a .json file. All data can be accessed, updated, and deleted accordingly.

using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Assignment5_MiguelStoyke
{
    public partial class Form1 : Form
    {
        //Class variables
        List<Student> students = new List<Student>(); //Main students list for datagridview
        private List<Campus> originalCampuses;  // Store all campuses

        private bool isInitialized = false; //Checks if app has been initialized
        private string province;
        private Dictionary<string, List<Program>> provinceProgramsMap; //Dictionary map to determine which programs are available at a campus
        private static string pathToJson = "C:\\Users\\techu\\Documents\\Durham College\\Fall 2023\\Object Oriented Programming 2 (COSC 2100)\\Projects\\Assignment5_MiguelStoyke\\bin\\Debug\\net6.0-windows\\StudentRegistrations.json";

        public Form1()
        {
            InitializeComponent();
            PopulateCategories(); //Creates table headers

            isInitialized = true;

            //Initialize the campus/program dictionary
            provinceProgramsMap = new Dictionary<string, List<Program>>
            {
                { "ON", GetPrograms1() },
                { "QC", GetPrograms2() },
                { "NS", GetPrograms1() },
                { "NB", GetPrograms2() },
                { "MB", GetPrograms1() },
                { "BC", GetPrograms2() },
                { "PE", GetPrograms1() },
                { "SK", GetPrograms2() },
                { "AB", GetPrograms1() },
                { "NL", GetPrograms2() }
            };

            //Display campuses
            PopulateCampuses();

            ProgramsCombo.Enabled = false;

            //Default values
            ProgramsCombo.SelectedIndex = -1;
            StudyPeriodNumLabel.Text = "0";
            TotalCostNumLabel.Text = "$0.00";
            CampLocCombo.SelectedIndex = -1;

            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Escape key triggers removeallbutton
            if (e.KeyCode == Keys.Escape)
            {
                RemoveAllButton.PerformClick();
            }
        }

        //sets values back to default
        private void ClearInputs()
        {
            FNameText.Text = "";
            LNameText.Text = "";
            SINText.Text = "";
            EmailText.Text = "";
            AdmissionTestCombo.SelectedIndex = -1;
            HighSchoolCombo.SelectedIndex = -1;
            ProgramsCombo.SelectedIndex = -1;
            CampLocCombo.SelectedIndex = -1;
            StudyPeriodNumLabel.Text = "0";
            TotalCostNumLabel.Text = "$0.00";
            CampLocCombo.Enabled = false;
            ProgramsCombo.Enabled = false;
        }

        //Determines the item selected from student sin numbers in the system
        private void SINCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Determines if an item is selected and converts to string
            string selectedSIN = SINCombo.SelectedItem?.ToString();

            //If a sin in the system is selected, re populate input fields with existing data
            if (!string.IsNullOrEmpty(selectedSIN))
            {
                UpdateInputFields(selectedSIN);
                SINText.Text = selectedSIN;
            }
            else
            {
                ClearInputs();
            }
        }

        //Populates input fields with selected student data from datagridview
        private void StudentView_SelectionChanged(object sender, EventArgs e)
        {
            //Check if there is at least one selected row
            if (StudentView.SelectedRows.Count > 0)
            {
                //Get selected row
                DataGridViewRow selectedRow = StudentView.SelectedRows[0];

                //Get selected students SIN number
                string selectedSIN = selectedRow.Cells["SIN"].Value?.ToString();

                //Call UpdateInputFields with the selected students SIN num
                UpdateInputFields(selectedSIN);
                SINText.Text = selectedSIN;

                if (!SINCombo.Items.Contains(selectedSIN))
                {
                    SINCombo.Items.Add(selectedSIN);
                }
                SINCombo.SelectedItem = selectedSIN;
            }
        }

        //Determines the item selected from available programs in the system
        private void ProgramsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if a program and campus object have been appropriately selected
            if (ProgramsCombo.SelectedItem is Program selectedProgram && CampLocCombo.SelectedItem is Campus selectedCampus)
            {
                //Calculate the total cost by adding program fees and registration fees
                int totalCost = selectedProgram.ProgramFees + selectedCampus.RegFees;

                //Update the labels with the corresponding study period and total cost
                StudyPeriodNumLabel.Text = selectedProgram.ProgramDuration.ToString();
                TotalCostNumLabel.Text = totalCost.ToString("C2");
            }
        }

        //Determines the item selected from all campuses in the system
        private void CampLocCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checks if the dictionary is a null value
            if (provinceProgramsMap == null)
            {
                MessageBox.Show("Dictionary Null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Uses general event check to see if the action was from a combobox and is from Campus Locations, AND it contains a selected value
            if (sender is ComboBox comboBox && comboBox.Name == "CampLocCombo" && comboBox.SelectedIndex != -1)
            {
                //Only updates input fields given the data exists
                if (comboBox.DroppedDown)
                {
                    UpdateInputFields(SINCombo.SelectedItem?.ToString());
                }
            }

            PopulatePrograms();  //Programs display
        }

        //Validates email address format using built in .Net formatting tool
        private bool ValidateEmail(string email)
        {
            try
            {
                //auto variable type
                var emailAdd = new System.Net.Mail.MailAddress(email);

                //makes sure the email ends with .ca or .com
                if (email.EndsWith(".ca") || email.EndsWith(".com"))
                {
                    return true;
                }

                return false;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //General input validation
        private bool ValidateStudentInformation()
        {
            if (string.IsNullOrEmpty(FNameText.Text))
            {
                MessageBox.Show("Please enter a First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(LNameText.Text))
            {
                MessageBox.Show("Please enter a Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(SINText.Text) || SINText.Text.Length < 9)
            {
                MessageBox.Show("Please enter a valid SIN number with at least 9 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(EmailText.Text))
            {
                MessageBox.Show("Please enter an Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ValidateEmail(EmailText.Text))
            {
                MessageBox.Show("Please enter a valid Email (hint: @, .ca, .com).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AdmissionTestCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Admission Test Score", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (HighSchoolCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your High School Grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Validation passed
            return true;
        }

        //General validation for program and campus selection
        private bool ValidateAvailablePrograms()
        {
            //Checks for selected values
            if (CampLocCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Campus Location", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (ProgramsCombo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your Program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Validation passed
            return true;
        }

        //First list of available programs
        private List<Program> GetPrograms1()
        {
            return new List<Program>
            {
                new Program("Computer Programming", 5000, 2),
                new Program("Computer Programmer Analyst", 7000, 3),
                new Program("Computer Systems Technology", 7000, 3)
            };
        }

        //Second list of available programs
        private List<Program> GetPrograms2()
        {
            return new List<Program>
            {
               new Program("Computer Systems Technician", 5000, 2),
               new Program("Bachelors of Science - Computer Science", 20000, 4),
               new Program("Bachelors of IT - Networking and Security", 18000, 4)
            };
        }

        //Creates campus objects, determins available programs by alternating list 1 and 2 for each province in the list
        private void PopulateCampuses()
        {
            //Create object list to populate
            List<Campus> campuses = new List<Campus>();

            //Adds the camuses to the list and determines program list
            campuses.Add(new Campus("ON", 50, 60, 5000, GetPrograms1()));
            campuses.Add(new Campus("QC", 70, 50, 4500, GetPrograms2()));
            campuses.Add(new Campus("NS", 70, 50, 4800, GetPrograms1()));
            campuses.Add(new Campus("NB", 50, 50, 4000, GetPrograms2()));
            campuses.Add(new Campus("MB", 60, 70, 5500, GetPrograms1()));
            campuses.Add(new Campus("BC", 80, 60, 5200, GetPrograms2()));
            campuses.Add(new Campus("PE", 90, 70, 4800, GetPrograms1()));
            campuses.Add(new Campus("SK", 90, 60, 4200, GetPrograms2()));
            campuses.Add(new Campus("AB", 70, 50, 4900, GetPrograms1()));
            campuses.Add(new Campus("NL", 80, 60, 5100, GetPrograms2()));

            //Sets data source for combo box and determines the appropriate display member
            CampLocCombo.DataSource = campuses;
            CampLocCombo.DisplayMember = "Province";

            originalCampuses = new List<Campus>(campuses);
        }

        //Uses the provinceMap dictionary to display the appropriate programs into the lists
        private void PopulatePrograms()
        {
            //Checks if the user has selected a campus in the list
            if (CampLocCombo.SelectedItem is Campus selectedCampus)
            {
                //Assigns display member to a string
                string selectedProvince = selectedCampus.Province;

                //Check if the selected province is in the dictionary
                if (provinceProgramsMap.ContainsKey(selectedProvince))
                {
                    //Retrieve programs for the selected province
                    List<Program> programs = provinceProgramsMap[selectedProvince];

                    ProgramsCombo.DataSource = programs;
                    ProgramsCombo.DisplayMember = "ProgramName";
                    ProgramsCombo.Enabled = true;
                }
                else
                {
                    //Returns empty
                    ProgramsCombo.DataSource = new List<Program>();
                    ProgramsCombo.Enabled = false;
                }
            }
        }

        //Populate table headers as long as they are not null
        private void PopulateCategories()
        {
            if (StudentView.Columns["FirstName"] != null)
            {
                StudentView.Columns["FirstName"].HeaderText = "First Name";
            }

            if (StudentView.Columns["LastName"] != null)
            {
                StudentView.Columns["LastName"].HeaderText = "Last Name";
            }

            if (StudentView.Columns["SIN"] != null)
            {
                StudentView.Columns["SIN"].HeaderText = "SIN";
            }

            if (StudentView.Columns["Email"] != null)
            {
                StudentView.Columns["Email"].HeaderText = "Email";
            }

            if (StudentView.Columns["HighSchoolGrade"] != null)
            {
                StudentView.Columns["HighSchoolGrade"].HeaderText = "High School Grade";
            }

            if (StudentView.Columns["AdmissionTestScore"] != null)
            {
                StudentView.Columns["AdmissionTestScore"].HeaderText = "Admission Test Score";
            }

            if (StudentView.Columns["CampusLocation"] != null)
            {
                StudentView.Columns["CampusLocation"].HeaderText = "Campus Location";
            }

            if (StudentView.Columns["Program"] != null)
            {
                StudentView.Columns["Program"].Width = 238;
                StudentView.Columns["Program"].HeaderText = "Program";
            }
        }

        //Exit Application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Saves data to StudentRegistrations.java when LoadButton is clicked
        private void SaveData()
        {
            try
            {
                //Makes a list of existing students in the datagridview
                List<Student> existingRecords = new List<Student>();

                //Check if the JSON file exists
                if (File.Exists(pathToJson))
                {
                    //Read existing records from the JSON file
                    string existingJson = File.ReadAllText(pathToJson);
                    existingRecords = JsonConvert.DeserializeObject<List<Student>>(existingJson); //Deserialize object list
                }

                //Appends the main list of students to the new list
                existingRecords.AddRange(students);
                //Serializes the records
                string json = JsonConvert.SerializeObject(existingRecords, Formatting.Indented);
                //Writes to the file based on the given file path
                File.WriteAllText(pathToJson, json);

                //Sets application back to default state once file is saved
                students.Clear();
                ClearDataSource();
                ClearInputs();
                SINCombo.Items.Clear();

                MessageBox.Show("Successfully saved data to server.", "Load Successful (StudentRegistrations.json)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving records StudentRegistrations.json: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Saves data when load button is clicked
        private void LoadButton_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        //Reset data source as needed
        private void ClearDataSource()
        {
            StudentView.DataSource = null;
        }

        //Registers a new student into the datagridview
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string sin = SINText.Text;

            //Check if a student with the same SIN already exists
            if (students.Any(student => student.SIN == sin))
            {
                MessageBox.Show("Student with the same SIN already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Performs validation before creating the record
            else if (ValidateStudentInformation() && ValidateAvailablePrograms())
            {
                Student newRecord = new Student
                (
                    FNameText.Text,
                    LNameText.Text,
                    SINText.Text,
                    EmailText.Text,
                    int.Parse(HighSchoolCombo.SelectedItem.ToString()),
                    int.Parse(AdmissionTestCombo.SelectedItem.ToString()),
                    CampLocCombo.SelectedItem.ToString(),
                    ProgramsCombo.SelectedItem.ToString()
                );

                //Adds record and resets to default
                students.Add(newRecord);
                ClearDataSource();
                ClearInputs();
                StudentView.DataSource = students; //Uses the students list as the data source

                //Validation to check if the student is already in the system
                if (!SINCombo.Items.Contains(SINText.Text))
                {
                    SINCombo.Items.Add(newRecord.SIN);
                }
                else
                {
                    MessageBox.Show("Student is Already Registered.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //Checks if the student meets the minimum grade requirements for the campus
        private void CheckButton_Click(object sender, EventArgs e)
        {
            int admissionTestConvert;
            int highSchoolConvert;

            //Parses as int
            if (int.TryParse(AdmissionTestCombo.Text, out admissionTestConvert)
                && int.TryParse(HighSchoolCombo.Text, out highSchoolConvert))
            {
                //Creates list of eligible campuses for the student
                List<Campus> eligibleCampuses = new List<Campus>();

                //Searches through the full list of campuses to determine which ones the student is eligible for based on admission and high school requirements
                foreach (Campus campus in originalCampuses)
                {
                    if (admissionTestConvert >= campus.AdmissionTSReq
                        && highSchoolConvert >= campus.HSGradeReq)
                    {
                        //Adds the given campuses to the new list
                        eligibleCampuses.Add(campus);
                    }


                    //If there is at least 1 eligible campus
                    if (eligibleCampuses.Count > 0)
                    {
                        //Update the combo box items with eligible campuses
                        CampLocCombo.DataSource = eligibleCampuses;
                        CampLocCombo.DisplayMember = "Province";
                        CampLocCombo.Enabled = true;

                        MessageBox.Show("Student is eligible for admission to the displayed campuses.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //No eligible campuses
                        MessageBox.Show("Student is not eligible for admission to any campuses.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //Invalid grade input
                MessageBox.Show("Please enter valid admission test score and high school grade.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Updates input fields on command for student selection
        private void UpdateInputFields(string selectedSIN)
        {
            //Find the student with the selected SIN
            Student selectedStudent = students.Find(student => student.SIN == selectedSIN);

            //If the student is found, populate the input fields
            if (selectedStudent != null)
            {
                if (FNameText.Text != selectedStudent.FirstName)
                    FNameText.Text = selectedStudent.FirstName;

                if (LNameText.Text != selectedStudent.LastName)
                    LNameText.Text = selectedStudent.LastName;

                if (EmailText.Text != selectedStudent.Email)
                    EmailText.Text = selectedStudent.Email;

                if (HighSchoolCombo.SelectedItem?.ToString() != selectedStudent.HighSchoolGrade.ToString())
                    HighSchoolCombo.SelectedItem = selectedStudent.HighSchoolGrade.ToString();

                if (AdmissionTestCombo.SelectedItem?.ToString() != selectedStudent.AdmissionTestScore.ToString())
                    AdmissionTestCombo.SelectedItem = selectedStudent.AdmissionTestScore.ToString();

                //Check if the selected value is different
                if (CampLocCombo.SelectedItem?.ToString() != selectedStudent.CampusLocation)
                {
                    //Set selected index for CampusLocation
                    int campusLocationIndex = CampLocCombo.FindStringExact(selectedStudent.CampusLocation);
                    CampLocCombo.SelectedIndex = campusLocationIndex;
                }

                //Check if the selected value is different
                if (ProgramsCombo.SelectedItem?.ToString() != selectedStudent.Program)
                {
                    //Set selected index for Programs
                    int programIndex = ProgramsCombo.FindStringExact(selectedStudent.Program);
                    ProgramsCombo.SelectedIndex = programIndex;
                }

                CampLocCombo.Enabled = false;
                ProgramsCombo.Enabled = false;
            }
        }

        //Updates an existing student record
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //Keep combo boxes enabled for editing
            ProgramsCombo.Enabled = true;
            CampLocCombo.Enabled = true;

            //If no students are available
            if (SINCombo.Items.Count == 0)
            {
                MessageBox.Show("No SINs available in the system.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedSIN = SINCombo.SelectedItem?.ToString(); //Checks if a SIN has been selected

            //If no SIN is selected
            if (string.IsNullOrEmpty(selectedSIN))
            {
                MessageBox.Show("Please select a SIN number to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Searches the students list using a temp object to find the specified student
            Student selectedStudent = students.Find(student => student.SIN == selectedSIN);

            if (CampLocCombo.SelectedItem is Campus selectedCampus)
            {
                if (ValidateStudentInformation() && ValidateAvailablePrograms())
                {
                    if (int.TryParse(AdmissionTestCombo.Text, out int admissionTestConvert)
                        && int.TryParse(HighSchoolCombo.Text, out int highSchoolConvert)
                        && admissionTestConvert >= selectedCampus.AdmissionTSReq
                        && highSchoolConvert >= selectedCampus.HSGradeReq)

                    {
                        //Update the student's information with the modified values
                        selectedStudent.FirstName = FNameText.Text;
                        selectedStudent.LastName = LNameText.Text;
                        selectedStudent.Email = EmailText.Text;
                        selectedStudent.HighSchoolGrade = int.Parse(HighSchoolCombo.SelectedItem.ToString());
                        selectedStudent.AdmissionTestScore = int.Parse(AdmissionTestCombo.SelectedItem.ToString());
                        selectedStudent.CampusLocation = CampLocCombo.SelectedItem.ToString();
                        selectedStudent.Program = ProgramsCombo.SelectedItem.ToString();

                        ClearDataSource();
                        StudentView.DataSource = students;

                        MessageBox.Show("Student information updated successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearInputs();
                    }
                    else
                    {
                        MessageBox.Show("Student is Not Eligible for Admission.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Deletes a selected student from the list
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SINCombo.Items.Count == 0)
            {
                MessageBox.Show("No SINs available in the system.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedSIN = SINCombo.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSIN))
            {
                MessageBox.Show("Please select a SIN number to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Student selectedStudent = students.Find(student => student.SIN == selectedSIN);

            //Removes the selected student from the list and from the SINCombo
            students.Remove(selectedStudent);
            SINCombo.Items.Remove(selectedSIN);

            ClearDataSource();
            StudentView.DataSource = students;
            ClearInputs();

            MessageBox.Show("Record deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            students.Clear(); //Clear main students list
            SINCombo.Items.Clear(); //Clear all items in SINCombo
            ClearDataSource();
            ClearInputs();

            ProgramsCombo.Enabled = false;
            CampLocCombo.Enabled = false;

            MessageBox.Show("All records removed successfully.", "Remove All Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterButton.PerformClick();
        }

        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateButton.PerformClick();
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteButton.PerformClick();
        }

        private void deleteAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveAllButton.PerformClick();
        }

        private void loadRecordsToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadButton.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitButton.PerformClick();
        }

        private void technicalSupportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //My info
            string name = "Miguel Stoyke";
            string id = "100693374";
            string email = "miguel.stoyke@dcmail.ca";
            string message = $"Name: {name}\nID: {id}\nEmail: {email}";

            //Message box with info - ok button exits the app
            DialogResult info = MessageBox.Show(message, "Technical Supports", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (info == DialogResult.OK)
            {
                ExitButton.PerformClick();
            }
        }

        private void aboutDCRegistrationAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string appDescription = "This app was developed for the purpose of Durham College staff to track and register eligible students into a mock college database run through a .json file. All data can be accessed, updated, and deleted accordingly.";

            DialogResult info = MessageBox.Show(appDescription, "About DC-Registration App", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (info == DialogResult.OK)
            {
                ExitButton.PerformClick();
            }
        }
    }
}