using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        // Массив. Количество нечентных положительных элементов на четных местах массива
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random n = new Random();
            int count = 0;

            for (int i = 0; i < 20; i++)
            {
                arr[i] = n.Next(-50, 50); // Генерация случайного элемента массива
            }

            for (int i = 1; i <= 20; i += 2)
            {
                if (arr[i] > 0 && arr[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine("Сгенерированный массив:");

            foreach (int a in arr)
            {
                Console.Write("{0} ", a);
            }

            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов на четных местах = " + count);
            Console.ReadKey();

        }
    }
}
