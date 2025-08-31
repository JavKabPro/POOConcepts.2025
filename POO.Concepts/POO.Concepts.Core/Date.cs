using System.Diagnostics.Metrics;
using System.Formats.Tar;

namespace POO.Concepts.Core;

public class Date               //Attributes
{
    private int _day;
    private int _month;
    private int _year;

    public Date()               //Constructor method
    {
        Year = 1900;
        Month = 1;
        Day = 1;
    }

    public Date(int  year, int month, int day)  //Constructor method (Overload)
    {                           //It is defined by the number of parameters and the type of parameters.
        Year = year;            //If I put the same number of data and data type in two constructor methods, it cannot be done.
        Month = month; 
        Day = day;
    }
    public int Day              //Public properties must begin with a capital letter.  
    {
        get => _day;            //I want properties to be linked to attributes.
        set                     //... and I want that the privates attributes have relation with
        {                       //publics properties...
            _day = ValidateDay(value);
        }
    }
    public int Month 
    {
        get => _month;          //Replaced with arrow notation
        set
        {
            _month =ValidateMonth(value);
        }
    }
    public int Year 
    {
        get => _year;           //Replaced with arrow notation
        set
        {
            _year = ValidateYear(value);
        }
    }

    public override string ToString()
    {
        return $"{Year:0000}/{Month:00}/{Day:00}"; //Interpolation and format in which I want the hours
    }

    private bool IsLapYear(int year)            //Method IsLapYear
    {
        return (year % 4 == 0 && year % 100 == 0) || (year % 400 == 0);
    }

    private int ValidateYear(int year) 
    {
        if (year < 0)
        {
            throw new Exception("Year cannot be negative.");
        }
        return year;
    }

    private int ValidateMonth(int month)
    {
        if (month < 1 || month > 12)
        {
            throw new Exception($"The month: {month}, is not valid");
        }
        return month;
    }

    private int ValidateDay(int day)
    {
        int maxDay = Month switch
        {
            2 => IsLapYear(Year) ? 29 : 28,
            4 or 6 or 9 or 11 => 30,
            _ => 31,
        };
        if (day >= 1 && day <= maxDay)
        return day;

        throw new Exception($"The day: {day}, is not valid for month: {Month} and year: {Year}");
        }
    }
