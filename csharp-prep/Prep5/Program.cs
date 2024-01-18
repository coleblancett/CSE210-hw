using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program! ");
        }

        static string PromptUserName(){
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(){
            Console.WriteLine("Please enter your favorite number: ");
            int userNum = int.Parse(Console.ReadLine());
            return userNum;
        }

        static int SquareNumber(int userNum){
            int squared = userNum * userNum;
            return squared;
        }

        static void DisplayResult(int squared, string userName){
            Console.WriteLine($"{userName}, the sqaure of your number is {squared}");
        }

        DisplayWelcome();

        string name = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNum = SquareNumber(userNumber);

        DisplayResult(squaredNum, name);
    }
}