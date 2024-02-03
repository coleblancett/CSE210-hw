using System;
using System.Reflection.Metadata;

public class Menu
{
    public string WelcomeMessage;
    public string Instructions;
    public List<string> Options;
    public string Prompt;

    public string Run(){
        Console.Clear();
        Console.WriteLine(WelcomeMessage);
        Console.WriteLine(Instructions);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }
        Console.Write(Prompt);
        bool success = int.TryParse(Console.ReadLine(), out int selection);
        if (!success || selection > Options.Count){
            return Run();
        }
        return Options[selection - 1];
    }

}