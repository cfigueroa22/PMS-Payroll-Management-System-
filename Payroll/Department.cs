/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System 

Description:
*/
public class Department : Departments 
{
    public int YearsEmployeed { get; set; }

    public Department(string dept, string job, int years)
        : base(dept, job)
    {
        YearsEmployeed = years;
    }

    public override string YearOfEmployment()
    {
        return "\nYears of Employment: " + YearsEmployeed;
    }
}