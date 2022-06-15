using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 - FortuneCookie - "печенье с предсказаниями"
            //"win a Jackpot"
            //"fall in love"
            //"get a love letter"
            //"miss the bus"
            //"see a unicorn un the street"
            //Приложение показывает в консоли предсказание для пользователя, выбранное случайным образом из приведенного выше списка.

            string[] future = { "win a Jackpot", "fall in love", "get a love letter", "miss the bus", "see a unicorn un the street" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, future.Length);
            Console.WriteLine("Do you wish to know your future wright now?");
            Console.WriteLine();

            Console.WriteLine($"Here is your future: {future[randomIndex]}...");
            Console.WriteLine("Good luck!");
        }
    }
}
