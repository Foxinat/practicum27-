using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum27
{
    public class ReverseArrayReverseOnly
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = int.Parse(Console.ReadLine());

            int[] myArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(myArray); // Разворачиваем массив

            Console.WriteLine("\nМассив в обратном порядке (Reverse):");
            foreach (int element in myArray)
            {
                Console.Write(element + " ");
            }

            Console.ReadKey();
        }
    }
}