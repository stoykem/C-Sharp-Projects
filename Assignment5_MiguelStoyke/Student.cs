//Name: Miguel Stoyke
//App Name: DC Registration App (Student.cs)
//Date Created: November 26th, 2023
//Last Modified: December 4th, 2023
//Description: This app was developed for the purpose of Durham College staff to track and register eligible students into a mock college database run through a .json file. All data can be accessed, updated, and deleted accordingly.

using System;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SIN { get; set; }
    public string Email { get; set; }
    public int HighSchoolGrade { get; set; }
    public int AdmissionTestScore { get; set; }
    public string CampusLocation { get; set; }
    public string Program { get; set; }


    public Student(string firstName, string lastName, string sin, string email, int highSchoolGrade, int admissionTestScore, string campusLocation, string program)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.SIN = sin;
        this.Email = email;
        this.HighSchoolGrade = highSchoolGrade;
        this.AdmissionTestScore = admissionTestScore;
        this.CampusLocation = campusLocation;
        this.Program = program;
    }
}
