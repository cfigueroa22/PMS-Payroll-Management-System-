/*
Name: Carlos Figueroa
Date: December 1, 2022
Assignment: CIS317 Payroll Management System

Description:
*/
public class Sensitive : Information
{
    public string Email { get; private set; }
    
    public Sensitive(string username, string password, string email)
        : base(username, password)
    {
        Email = email;
    }

    public void UpdateEmail(string email)
    {
        Email = email;
    }

    public void UpdateUsername(string username)
    {
        Username = username;
    }

    public void UpdatePassword(string password)
    {
        Password = password;
    }

    public override string ToString()
    {
        return
            "Username: " + Username + "\n" +
            "Password: " + Password + "\n" +
            "Email: " + Email;
    }
}