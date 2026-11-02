using System;
using System.Collections.Generic;
using Practica.Tasks.Level1;
using Practica.Tasks.Level2;
using Practica.Tasks.Level3;
using Practica.Common;

namespace Practica.Menu
{
    public class MenuRunner
    {
        private List<ITask> level1Tasks = new List<ITask>();
        private List<ITask> level2Tasks = new List<ITask>();
        private List<ITask> level3Tasks = new List<ITask>();

        public MenuRunner()
        {
            level1Tasks.Add(new Task1_HelloWorldDate());
            level1Tasks.Add(new Task2_PrimitiveTypes());
            level1Tasks.Add(new Task3_Calculator());
            level1Tasks.Add(new Task4_NumberParity());
            level1Tasks.Add(new Task5_TableOfMultiplication());
            level1Tasks.Add(new Task6_SumDNums());
            level1Tasks.Add(new Task7_ReverseString());
            level1Tasks.Add(new Task8_FizzBuzz());
            level1Tasks.Add(new Task9_Array());
            level1Tasks.Add(new Task10_Bubble());
            level1Tasks.Add(new Task11_DiagonalMat());
            level1Tasks.Add(new Task12_Palindrome());
            level1Tasks.Add(new Task13_Dictionary());
            level1Tasks.Add(new Task14_Age());
            level2Tasks.Add(new Task16_ExtensionMethods());
            level2Tasks.Add(new Task17_StringBuilder());
            level2Tasks.Add(new Task18_ParseVsCatch());
            level2Tasks.Add(new Task19_MyStack_Queue());
            level2Tasks.Add(new Task20_GeneralMethods());
            level2Tasks.Add(new Task21_DaysOfWeek());
            level2Tasks.Add(new Task22_ParamsOverload());
            level2Tasks.Add(new Task23_NullableType());
            level2Tasks.Add(new Task24_Animals());
            level2Tasks.Add(new Task25_IShape());
            level2Tasks.Add(new Task26_Strategy());
            level2Tasks.Add(new Task27_Student());
            level2Tasks.Add(new Task28_HashCode());
            level2Tasks.Add(new Task29_Factory());
            level2Tasks.Add(new Task30_Bank());
            level2Tasks.Add(new Task31_Disposable());
            level2Tasks.Add(new Task32_Temperature());
            level2Tasks.Add(new Task33_LinqEmployees());
            level2Tasks.Add(new Task34_GroupWords());
            level3Tasks.Add(new Task36_Dublicate());
            level3Tasks.Add(new Task37_Fibonacci());
            level3Tasks.Add(new Task38_ListVsLinkedList());
            level3Tasks.Add(new Task39_YieldEvenNumbers());
            level3Tasks.Add(new Task40_AsyncAwait());
            level3Tasks.Add(new Task41_ParallelTasks());
            level3Tasks.Add(new Task42_Cancellation());
            level3Tasks.Add(new Task43_ExceptionOrder());
            level3Tasks.Add(new Task44_TodoList());
            level3Tasks.Add(new Task45_Library());
        }
        public void Start()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== Практика по C# ===");
                Console.WriteLine("1. Уровень 1 — Базовый");
                Console.WriteLine("2. Уровень 2 — Средний");
                Console.WriteLine("3. Уровень 3 — Продвинутый");
                Console.WriteLine("0. Выход");
                Console.Write("\nВыберите уровень: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Level1Menu();
                }
                else if (choice == "2")
                {
                    Level2Menu();
                }
                else if (choice == "3")
                {
                    Level3Menu();
                }
                else if (choice == "0" || choice == "q")
                {
                    isRunning = false;
                }
            }
        }
        private void Level1Menu()
        {
            bool inLevel1 = true;
            while (inLevel1)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 1 ---");
                for (int i = 0; i < level1Tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {level1Tasks[i].Title}");
                }
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задание: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    inLevel1 = false;
                }
                else
                {
                    int index = int.Parse(choice) - 1;

                    if (index >= 0 && index < level1Tasks.Count)
                    {
                        Console.Clear();
                        ConsoleHelper.PrintTaskInfo(level1Tasks[index]);
                        level1Tasks[index].Run();
                        ConsoleHelper.Pause();
                    }
                }
            }
        }
        private void Level2Menu()
        {
            bool inLevel2 = true;
            while (inLevel2)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 2 ---");
                for (int i = 0; i < level2Tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {level2Tasks[i].Title}");
                }
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задание: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    inLevel2 = false;
                }
                else
                {
                    int index = int.Parse(choice) - 1;

                    if (index >= 0 && index < level2Tasks.Count)
                    {
                        Console.Clear();
                        ConsoleHelper.PrintTaskInfo(level2Tasks[index]);
                        level2Tasks[index].Run();
                        ConsoleHelper.Pause();
                    }
                }
            }
        }
        private void Level3Menu()
        {
            bool inLevel3 = true;
            while (inLevel3)
            {
                Console.Clear();
                Console.WriteLine("--- Уровень 3 ---");
                for (int i = 0; i < level3Tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {level3Tasks[i].Title}");
                }
                Console.WriteLine("0. Назад");
                Console.Write("\nВыберите задание: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    inLevel3 = false;
                }
                else
                {
                    int index = int.Parse(choice) - 1;

                    if (index >= 0 && index < level3Tasks.Count)
                    {
                        Console.Clear();
                        ConsoleHelper.PrintTaskInfo(level3Tasks[index]);
                        level3Tasks[index].Run();
                        ConsoleHelper.Pause();
                    }
                }
            }
        }
    }
}