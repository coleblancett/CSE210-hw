using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        int userNum = -1;
        List<int> nums = new List<int>();

        while (userNum != 0){
            Console.WriteLine("Please enter a number for the list (0 to stop) ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0){
                nums.Add(userNum);
            }
        }
        int sum = 0;

        foreach (int number in nums){
            
            sum += number;
        }
        Console.WriteLine($"The sum of all numbers is {sum}");

        float avg = ((float)sum) / nums.Count;
        Console.WriteLine($"The average of the numbers you entered is {avg}");

        int max = nums[0];

        foreach (int number in nums){

            if (number > max){
                max = number;
            }
        }
        Console.WriteLine($"The biggest number you entered was {max}");

        int min = nums[0];

        foreach (int number in nums){

            if (number < min){
                min = number;
            }
        }
        Console.WriteLine($"The biggest number you entered was {min}");
    }
}