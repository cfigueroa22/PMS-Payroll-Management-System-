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
        Console.WriteLine("\nCarlos Figueroa - PMS (Payroll Management System)\n");

        //This is the employee class using Composition       
        Employee e = new Employee(1, "John Smith", "123 Washington St.", "757-222-3333", 15.00);
        Console.WriteLine(e.ToString());
        Departments departments = new Department("Human Resources", "Recruiter", 5);
        Console.WriteLine(departments); 

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

        departments = new Department("Electronic Media", "Software Developer", 4);
        Console.WriteLine(departments);

        Console.WriteLine("\n---Sensitive Information---\n");
        Sensitive sensitive = new Sensitive("cfigueroa", "password1", "email@gmail.com");
        Console.WriteLine(sensitive);

        sensitive.UpdateUsername("djefferson");
        sensitive.UpdatePassword("password1");
        sensitive.UpdateEmail("email@gmail.com");

        Console.WriteLine("\n---Sensitive Information---\n");
        Console.WriteLine("Username: " + sensitive.Username);
        Console.WriteLine("Password: " + sensitive.Password);
        Console.WriteLine("E-Mail: " + sensitive.Email);
        

    }

    private static void PrintAttendance(Employee employee)
    {
        Console.WriteLine(employee.ToString());
    }
}