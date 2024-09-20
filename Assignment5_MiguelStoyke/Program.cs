using Assignment5_MiguelStoyke;
using System;
using System.Xml.Linq;
//Name: Miguel Stoyke
//App Name: DC Registration App (Program.cs)
//Date Created: November 26th, 2023
//Last Modified: December 4th, 2023
//Description: This app was developed for the purpose of Durham College staff to track and register eligible students into a mock college database run through a .json file. All data can be accessed, updated, and deleted accordingly.

public class Program
{
    public string ProgramName { get; set; }
    public int ProgramFees { get; set; }
    public int ProgramDuration { get; set; }

    //App would not work unless I generated a new instance of the form in this class
    //update - the class Program overwrites the system file Program.cs, so this needs to replace what was in the old Program.cs
    static void Main(string[] args)
    { 
        Form1 form = new Form1();
        Application.EnableVisualStyles();
        Application.Run(form);
    }

    public override string ToString()
    {
        return ProgramName;
    }

    public Program(string programName, int programFees, int programDuration)
	{
        this.ProgramName = programName;
        this.ProgramFees = programFees;
        this.ProgramDuration = programDuration;
	}
}
