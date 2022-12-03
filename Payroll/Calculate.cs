/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System

Description:
*/
public class Calculate : ICalculate
{

    public void GetPayment(double hoursWork, double rate)
    {
        double total; 
        total = rate * hoursWork;
        Console.WriteLine("Total Payment: ${0:F2}", total);
    }
}    