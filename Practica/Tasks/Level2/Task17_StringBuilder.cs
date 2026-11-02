using Practica.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Practica.Tasks.Level2
{
    internal class Task17_StringBuilder : ITask
    {
        public string Title => "StringBuilder vs конкатенация (замер)";
        public string Description => "Сравнить производительность конкатенации через + и StringBuilder.";
        public string[] Requirements => new[]
        {"Собрать строку из 10 000 чисел двумя способами.",
            "Замерить время каждого через Stopwatch.",
            "Вывести оба времени и разницу.",
            "Объяснить в комментарии, почему StringBuilder быстрее."
        };
        public void Run()
        {const int count = 10000;
            Stopwatch sw = new Stopwatch();
            Console.WriteLine($"Генерация строки из {count} чисел...");
            sw.Start();
            string result1 = "";
            for (int i = 0; i < count; i++)
            {result1 += i.ToString();
            }
            sw.Stop();
            long time1 = sw.ElapsedMilliseconds;
            sw.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {sb.Append(i);
            }
            string result2 = sb.ToString();
            sw.Stop();
            long time2 = sw.ElapsedMilliseconds;
            Console.WriteLine("\n--- Результаты ---");
            Console.WriteLine($"Конкатенация (+): {time1} мс");
            Console.WriteLine($"StringBuilder:   {time2} мс");
            Console.WriteLine($"Разница:   {time1 - time2} мс");
        }
        /*
        * 
        * Строки в C# (string) — неизменяемые (immutable) типы. 
        * Поэтому при использовании оператора "+" в цикле на каждой итерации в памяти создаётся новый строковый объект, 
        * в него копируется предыдущая строка и дописывается новая часть. 
        * На 10 000 итераций получится 10 000 временных строк — это создаёт серьёзную нагрузку на память и сборщик мусора (Garbage Collector) 
        * 
        * StringBuilder, напротив, работает с внутренним изменяемым массивом символов (буфером). 
        * При вызове Append символы просто дописываются в свободное место массива, а расширение происходит только при необходимости.
        * Такой подход избавляет от постоянного копирования строк.
        */
    }
}
