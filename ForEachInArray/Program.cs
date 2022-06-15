using System;

namespace ForEachInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple " };
            foreach(string item in fruits)//каждый элемент в массиве fruits
            {
                Console.WriteLine(item);
                if(item == "plums ")
                {
                    Console.WriteLine($"Boo, I dont like {item}");
                    //item = "tangerines"; - не сработает
                }
            }
        }
    }
}
