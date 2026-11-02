using Practica.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Tasks.Level1
{
    internal class Task11_DiagonalMat : ITask
    {
        public string Title => "Диагональ матрицы N×N";
        public string Description => "Найти сумму элементов главной диагонали матрицы N×N.";
        public string[] Requirements => new[]
        {"Размер N вводится пользователем (минимум 2).",
            "Матрица заполняется случайными числами.",
            "Сумма считается без LINQ, в одном цикле for.",
            "Вывести саму матрицу и сумму."
        };
        public void Run()
        {int n;
            while (true)
            {Console.Write("Введите размер матрицы N (минимум 2): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 2)
                {break;
                }
                Console.WriteLine("Ошибка! Введите целое число от 2 и больше.");
            }
            int[,] matrix = new int[n, n];
            Random rnd = new Random();
            Console.WriteLine("\nСгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {for (int j = 0; j < n; j++)
                {matrix[i, j] = rnd.Next(1, 10);
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {sum += matrix[i, i];
            }
            Console.WriteLine($"\nСумма элементов главной диагонали: {sum}");
        }
    }
}
