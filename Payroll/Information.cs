/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System 

Description:
*/
public class Information
{
    public string Username { get; protected set; }
    public string Password { get; protected set; }

    protected Information(string username, string password)
    {
        Username = username;
        Password = password;
    }
}