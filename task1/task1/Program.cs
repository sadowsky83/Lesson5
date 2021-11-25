using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Массив. Среднее арифметическое
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            double sum = 0;

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите элемент массива " + (i + 1) + " (целое число)");

                arr[i] = Convert.ToInt32(Console.ReadLine());

                sum += arr[i];
            }

            Console.WriteLine("Среднее арифметическое элементов массива равно " + Math.Round(sum / 7, 2));
            Console.ReadKey();
        }
    }
}
