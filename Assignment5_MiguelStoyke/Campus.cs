//Name: Miguel Stoyke
//App Name: DC Registration App (Campus.cs)
//Date Created: November 26th, 2023
//Last Modified: December 4th, 2023
//Description: This app was developed for the purpose of Durham College staff to track and register eligible students into a mock college database run through a .json file. All data can be accessed, updated, and deleted accordingly.

using System;

public class Campus
{
    public string Province { get; set; }
    public int HSGradeReq { get; set; }
    public int AdmissionTSReq { get; set; }
    public int RegFees { get; set; }
    public List<Program> ListPrograms { get; set; }

    public Campus()
    {
        this.ListPrograms = new List<Program>();
    }

    public Campus(string province, int hsGradeReq, int admissionTSReq, int regFees, List<Program> listPrograms)
    {
        this.Province = province;
        this.HSGradeReq = hsGradeReq;
        this.AdmissionTSReq = admissionTSReq;
        this.RegFees = regFees;

        // Checks if the program list for the campus is null. If it is null, the list is considered empty
        this.ListPrograms = listPrograms ?? new List<Program>();
    }

    public override string ToString()
    {
        return Province; 
    }
}

