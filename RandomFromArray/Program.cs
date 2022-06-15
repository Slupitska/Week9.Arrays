using System;

namespace RandomFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apples" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, fruits.Length);//from [0] to [5] (excluding 6)
            Console.WriteLine($"Here is your {fruits[randomIndex]}");
            
        }
    }
}
