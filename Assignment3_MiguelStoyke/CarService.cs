//Name: Miguel Stoyke
//App Name: Car Service Shop (Form1.cs)
//Date Created: October 29th, 2023
//Last Modified: November 5th, 2023
//Description: Tracks car services including customer/car details, and their selected services along with their costs. This is the CarService class that utilizes
//constructors for the user to create a record of type CarService
using System;

public class CarService
{

    public const double EOIL_CHANGE_COST = 60.0;
    public const double TOIL_CHANGE_COST = 120.0;
    public const double FILTER_CHANGE_COST = 40.5;
    public const double TAX = 1.13;


    //(needed some online research here) Retrieve the count number/service id
    //from the default constructor. their values are retrieved from serviceCount
    public int Count { get; } 
    public int Id { get; } 

    public static int serviceCount = 1;

    public int no;
    public string firstName;
    public string lastName;
    public string phoneNumber;
    public string make;
    public string model;
    public string colour;
    public int year;
    public bool engOilChange;
    public bool transOilChange;
    public bool airFilterChange;
    public double cost;

    public CarService()
	{
        Count = serviceCount;
        Id = serviceCount;
        serviceCount++;
    }

    public CarService(int no, string firstName, string lastName, string phoneNumber, string make, string model,
        string colour, int year, bool engOilChange, bool transOilChange, bool airFilterChange, double cost)
           : this()
    {
        this.no = no;
        this.firstName = firstName;
        this.lastName = lastName;
        this.phoneNumber = phoneNumber;
        this.make = make;
        this.model = model;
        this.colour = colour;
        this.year = year;
        this.engOilChange = engOilChange;
        this.transOilChange = transOilChange;
        this.airFilterChange = airFilterChange;
        this.cost = cost;
    }
}
