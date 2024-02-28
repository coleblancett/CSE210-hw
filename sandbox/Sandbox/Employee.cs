using System;
public class Employee : Person
{
    private string department;

    public Employee(string id, string name, string department) : base(id, name)
    {
        this.department = department;
    }
    public void Display()
    {
        Console.WriteLine($"{DisplayInfo} - {department}");
    }
}
