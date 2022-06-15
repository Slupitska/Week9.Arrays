using System;

namespace LoopingThroughTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple " };
            //fruits.Length = 5 (длина массива)
            //the index of the last element = array.Length - 1

            //fruits[6] = "kivi"; в наш массив 6й элемент добавить не можем, 
            //это сделано для оптимизации оперативной памяти

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

            Console.WriteLine();
            // Заменить апельсины (oranges) на мандарины (tingerines), не зная индекса апельсинов
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == "oranges")
                {
                    fruits[i] = "tangerines";
                }
            }

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }

        }
    }
}