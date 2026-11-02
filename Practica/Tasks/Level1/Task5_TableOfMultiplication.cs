using Practica.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.Tasks.Level1
{
    internal class Task5_TableOfMultiplication : ITask
    {
        public string Title => "Таблица умножения 10×10";
        public string Description => " вывести таблицу умножения 10×10";
        public string[] Requirements => new[]
        {"Использовать вложенные циклы for.",
            "Выровнять столбцы.",
            "Заголовки строк/столбцов — не обязательны, но приветствуются"
        };

        public void Run()
        { Console.WriteLine("Таблица умножения 10×10:");
            for (int i = 1; i <= 10; i++)
            { for (int j = 1; j <= 10; j++)
                {Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }
     }
}
