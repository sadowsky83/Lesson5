using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        // Массив. 10 случайных чисел
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random n = new Random();
            int tempNum;

            for (int i = 0; i < 10; i++)
            {
                arr[i] = n.Next(-50, 50); // Генерация случайного элемента массива
            }

            for (int i = 0; i < 5; i++) // Сортировка первых 5-и элемеентов по возрастанию
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        tempNum = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tempNum;
                    }
                }
            }

            for (int i = 5; i < 10 - 1; i++) // Сортировка последних 5-и элемеентов по убыванию
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        tempNum = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tempNum;
                    }
                }
            }

            Console.WriteLine("Отсортированный массив:");

            foreach (int a in arr)
            {
                Console.Write($"{a} "); // Погуглил варианты форматированного вывода
            }

            Console.ReadKey();
        }
    }
}
