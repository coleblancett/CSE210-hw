using System;
public class Person
{
    private string id;
    private string name;

    public Person(string id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public string DisplayInfo()
    {
        return $"{name}: {id}";
    }
}