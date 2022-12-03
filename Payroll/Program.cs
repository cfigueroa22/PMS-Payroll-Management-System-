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

        //This is the employee class using Composition       
        Employee e = new Employee(1, "John Smith", "123 Washington St.", "757-222-3333", 15.00);
        Console.WriteLine(e.ToString());

        //This is the attendance class using Polymorphism with a list
        Employee employee = new Employee(2, "Carlos Figueroa", "23 Water St.", "438-123-5432", 20.00);
        Attendance att = new Attendance(3, "Daniel Jefferson", "432 Jefferson Ave.", "342-342=5533", 20.00, 35, 7, false);

        List<Employee> employees = new List<Employee>();
        employees.Add(employee);
        employees.Add(att);

        Console.WriteLine("\nEmployees Attendance Record:");
        foreach (Employee a in employees)
        {
            PrintAttendance(a);
        }

        Calculate calc = new Calculate();
        calc.GetPayment(15.00, 40);

    }

    private static void PrintAttendance(Employee employee)
    {
        Console.WriteLine(employee.ToString());
    }
}