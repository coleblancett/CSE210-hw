using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress enter to hide a word or type 'quit' to exit.");
            if (Console.ReadLine().ToLower() == "quit") break;
            scripture.HideRandomWords(3);
        }
    }
}