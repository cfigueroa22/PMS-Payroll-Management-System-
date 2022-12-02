/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System

Description:
*/
public class Employee 
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public double HourlyRate { get; set; }

    public Employee(int id, string employeeName, string address, string phoneNum, double rate)
    {
        EmployeeId = id;
        EmployeeName = employeeName;
        Address = address;
        PhoneNumber = phoneNum;
        HourlyRate = rate; 
    }

    public override string ToString()
    {
        return string.Format("\nEmployeed ID: {0}\nEmployee Name: {1}\nAddress: {2}\nPhone Number: {3}\nHourly Rate: ${4:F2}", EmployeeId, EmployeeName, Address,  PhoneNumber, HourlyRate);
    }
}
