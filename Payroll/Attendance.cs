/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System 

Description:
*/
public class Attendance : Employee
{
    public double HoursWork { get; set; }
    public int DaysWork { get; set; }
    public bool OverTime { get; set; }

    public Attendance(int id, string employeeName, string address, string phoneNum, double rate, double hoursWork, int daysWork, bool overTime) : base(id, employeeName, address, phoneNum,rate)
    {
        HoursWork = hoursWork;
        DaysWork = daysWork;
        OverTime = overTime;
    }

    public override string ToString()
    {
        return string.Format(
            "{0}\nHours Worked: {1:F1}\nDays Worked: {2}\nOvertime: {3}",
            base.ToString(), HoursWork, DaysWork, OverTime);
    }

}