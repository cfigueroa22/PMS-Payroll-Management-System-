/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System

Description:
*/
public abstract class Departments
{
    public string DeptName { get; set; }
    public string JobPosition { get; set; }

    public Departments(string dept, string job)
    {
        DeptName = dept;
        JobPosition = job; 
    }

    public abstract string YearOfEmployment();

    public override string ToString()
    {
        return
            "Department Name: " + DeptName +
            "\nJob Position: " + JobPosition +
            YearOfEmployment();
    }
}