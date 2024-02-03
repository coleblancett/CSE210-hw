using System;
using System.Text.Json;
using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();

        menu.WelcomeMessage = "Welcome to the Journal Program!";
        menu.Instructions = "Please select one of the following choices:";
        menu.Options = new(){"Write", "Display", "Load", "Save", "Quit"};
        menu.Prompt = "What would you like to do? ";
        string selectedOption = null;
        List<Entry> entryLog = new();

        while (selectedOption != "Quit") {
            selectedOption = menu.Run();

            if (selectedOption == "Write")
            {
                Console.Clear();
                string randomPrompt = GenerateRandomPrompt();
                Entry entry = Entry.Create(randomPrompt);
                entryLog.Add(entry);
            }
            if (selectedOption == "Display")
            {
                Console.Clear();
                foreach (Entry entry in entryLog)
                {
                    Console.WriteLine(entry);
                }
                Console.Write("Press 'Enter' to continue.");
                Console.ReadLine();
            }
            if (selectedOption == "Save")
            {
                string json = JsonSerializer.Serialize(entryLog);
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                using (StreamWriter file = new(fileName))
                {
                    file.WriteLine(json);
                }
            }
            if (selectedOption == "Load")
            {
                Console.WriteLine("What is the file name?");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                string json = System.IO.File.ReadAllLines(fileName)[0];
                entryLog = JsonSerializer.Deserialize<List<Entry>>(json);
            }
        }
    }
    private static List<string> _listOfPrompts = new()
    {
        "What was the best part of today?",
        "What is one thing you wish you did better today?",
        "What blessings have I seen today?",
        "How can I be better tomorrow",
        "What are you most grateful for today?"
    };
    
    private static Random _random = new();
    private static string GenerateRandomPrompt()
    {
        int i = _random.Next(0, _listOfPrompts.Count);
        string randomPrompt = _listOfPrompts[i];
        return randomPrompt;
    }

}