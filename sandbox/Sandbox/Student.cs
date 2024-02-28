using System;
using System.Runtime.CompilerServices;
public class Student : Person
{
    private string major;

    public Student(string id, string name, string major) : base(id, name)
    {

        this.major = major;
    }
    public void Display()
    {
        Console.WriteLine($"{DisplayInfo} - {major}");
    }
}