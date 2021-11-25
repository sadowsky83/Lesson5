using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {   
        // Массив. Сумма макс и мин элемента
        static void Main(string[] args)
        {
            int[] arr = new int[15];
            Random n = new Random();            

            for (int i = 0; i < 15; i++)
            {
                arr[i] = n.Next(0, 50); // Генерация случайного элемента массива
            }

            int max = arr.Max();
            int min = arr.Min();

            Console.WriteLine("Сгенерированный массив:");

            foreach (int a in arr)
            {
                Console.Write("{0} ", a);
            }

            Console.WriteLine();
            Console.WriteLine("Минимальный элемент в массиве = " + min);
            Console.WriteLine("Максимальный элемент в массиве = " + max);
            Console.WriteLine("Сумма максимального и минимального элемента в массиве = " + (min + max));
            Console.ReadKey();
        }
    }
}
