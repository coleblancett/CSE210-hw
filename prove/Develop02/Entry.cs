using System;

public class Entry
{
    public DateTime Created { get; set; } = DateTime.Now;
    public string Prompt { get; set; }
    public string Response { get; set; }

    public static Entry Create(string prompt)
    {
        Entry entry = new();
        entry.Prompt = prompt;
        Console.WriteLine(entry.Prompt);
        Console.Write("> ");
        entry.Response = Console.ReadLine();
        return entry;
    }

    public override string ToString()
    {
        return $"Date: {Created.ToShortDateString()} - Prompt: {Prompt}\n{Response}";
    }

}