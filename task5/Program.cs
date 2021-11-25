using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        // Двумерный массив
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int num = (Convert.ToInt32(Console.ReadLine()));
            int[,] arr = new int[num, num];

            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        arr[i, j] = 1 - (i + j) % 2;

                        Console.Write("{0,4} ", arr[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Массив пуст");
                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
