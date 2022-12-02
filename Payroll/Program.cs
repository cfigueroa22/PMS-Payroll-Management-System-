/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System

Description: Main class application.
*/
public class PMS
{
    public static void Main(string[] args)
    {
        Employee e = new Employee(1, "John Smith", "123 Washington St.", "757-222-3333", 15.00);
        Console.WriteLine(e.ToString());
    }
}