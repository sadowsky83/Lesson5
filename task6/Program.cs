using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        // Двумерный массив. Магический квадрат
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива (целое число)");
            int num = (Convert.ToInt32(Console.ReadLine()));
            int[,] arr = new int[num, num]; // Двумерный массив            
            int[] arrStringSumm = new int[num];  // Массив сумм строк            
            int[] arrColumnSumm = new int[num];  // Массив сумм столбцов
            int diagonalSumm1 = 0;  // Cуммы диагоналей
            int diagonalSumm2 = 0;
            bool magicSq = true;

            for (int i = 0; i < num; i++)
            {
                arrColumnSumm[i] = 0;
            }

            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.WriteLine("Введите значение элементов массива с координатами " + (i + 1) + ": " + (j + 1) + " (целое число)");
                        arr[i, j] = (Convert.ToInt32(Console.ReadLine()));  // Задание значений элементам массива
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Ваш массив: ");
                Console.WriteLine();

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("{0,4} ", arr[i, j]); // Вывод массива
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Суммы строк: ");
                Console.WriteLine();

                for (int i = 0; i < num; i++)
                {
                    int summ = 0;

                    for (int j = 0; j < num; j++)
                    {
                        summ += arr[i, j];
                    }
                    arrStringSumm[i] = summ; // Заполняем массив сумм строк
                    Console.Write("{0,4} ", arrStringSumm[i]); // Вывод массива сумм строк
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Суммы столбцов: ");
                Console.WriteLine();

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        arrColumnSumm[j] += arr[i, j];  // Заполняем массив сумм столбцов
                    }
                }

                for (int i = 0; i < num; i++)
                {
                    Console.Write("{0,4} ", arrColumnSumm[i]); // Вывод массива сумм столбцов
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Сумма элементов по диагонали от 1: 1 до 1: " + num);
                Console.WriteLine();

                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j < num; j++)
                    {
                        if (i == j)
                        {
                            diagonalSumm1 += arr[i, j];  // Вычисление суммы по диагонали от элемента 1: 1 до num: num
                        }
                    }
                }

                Console.Write("{0,4} ", diagonalSumm1); // Вывод суммы по диагонали от элемента 1: 1 до num: num

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Сумма элементов по диагонали от 1: " + num + " до " + num + ": 1");
                Console.WriteLine();

                for (int i = 0; i < num; i++)
                {
                    for (int j = num; j >= 0; j--)
                    {
                        if (i + j == num - 1)
                        {
                            diagonalSumm2 += arr[i, j]; // Вычисление суммы по диагонали от элемента 1: num до num: 1
                        }

                    }
                }

                Console.Write("{0,4} ", diagonalSumm2); // Вывод суммы по диагонали от элемента 1: num до num: 1

                for (int i = 0; i < num; i++)
                {
                    if (diagonalSumm1 != diagonalSumm2 || arrStringSumm[i] != arrColumnSumm[i] || arrStringSumm[i] != diagonalSumm1 || arrColumnSumm[i] != diagonalSumm1)
                    {
                        magicSq = false;
                        break;
                    }
                }

                if (magicSq == true)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Это самый магический квадрат из всех!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Квадрат не магический(");
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
