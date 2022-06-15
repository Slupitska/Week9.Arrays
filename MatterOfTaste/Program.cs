using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2 - MatterOfTaste - "о вкусах не спорят"
            //Любимые цвет компьютера - red, green, blue
            //Компьютер просит ввести название любимого цвета пользователя.
            //Если введенный пользователем цвет совпадает с одним из любимых цветов компьютера, компьютер выводит на экран "We are perfect together", если любимый цвет пользователя не совпадает  с предпочтениями компьютера, на экран выводится фраза "Every man to his taste".
            //NB! Оба приложения должны быть выполнены с использованием массива


            //использовать цикл for либо for each
            //учесть, что пользователь может ввести цвет как с большой, так и с маленькой буквы


            string[] colors = { "red", "blue", "green" };
            Console.WriteLine("Enter your favorite color:");
            string userColor = Console.ReadLine().ToLower();
            foreach (string uColorHere in colors)

            if ((userColor == "red") || (userColor == "blue"))
            {
                System.Console.WriteLine("We are perfect together.");
                break;
            }
            else
            {
                Console.WriteLine("Every man to his taste.");
                break;
            }

        }
    }
}