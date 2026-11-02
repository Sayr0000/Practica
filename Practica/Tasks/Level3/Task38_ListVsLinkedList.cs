using Practica.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Practica.Tasks.Level3
{
    public class Task38_ListVsLinkedList : ITask
    {
        public string Title => "List<T> vs LinkedList<T> (бенчмарк)";
        public string Description => "Сравнить вставку в середину List<T> и LinkedList<T>.";
        public string[] Requirements => new[]
        {"Создать List<int> и LinkedList<int> по 100 000 элементов.",
            "Вставить 1000 элементов в середину каждой коллекции.",
            "Замерить время через Stopwatch.",
            "Вывести оба времени и объяснить результат в комментарии."
        };
        public void Run()
        {const int initialSize = 100000;
            const int insertCount = 1000;
            Console.WriteLine($"Готовим коллекции по {initialSize} элементов...\n");
            List<int> list = new List<int>();
            for (int i = 0; i < initialSize; i++) list.Add(i);
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < initialSize; i++) linkedList.AddLast(i);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < insertCount; i++)
            {int middle = list.Count / 2;
                list.Insert(middle, -1);
            }
            sw.Stop();
            long timeList = sw.ElapsedMilliseconds;
            Console.WriteLine($"List<T> вставка 1000 раз в середину:       {timeList} мс");
            sw.Restart();
            LinkedListNode<int> middleNode = linkedList.First;
            for (int i = 0; i < initialSize / 2; i++)
            {middleNode = middleNode.Next;
            }
            for (int i = 0; i < insertCount; i++)
            {linkedList.AddBefore(middleNode, -1);
            }
            sw.Stop();
            long timeLinkedList = sw.ElapsedMilliseconds;
            Console.WriteLine($"LinkedList<T> вставка 1000 раз в середину: {timeLinkedList} мс");
            Console.WriteLine($"\nРазница: List медленнее на {timeList - timeLinkedList} мс");
            /* 

             * 
             * Внутри List<T> лежит обычный массив. 
             * При вставке элемента в середину (list.Insert(middle, -1)), 
             * List вынужден сдвинуть все элементы справа от позиции вставки на одну ячейку вправо.
             * На списке из 100 000 элементов это означает копирование ~50 000 элементов при каждой вставке.
             * 1000 вставок дают 50 000 000 операций копирования — это медленно (O(n)).
             * 
             * LinkedList<T> — двусвязный список, состоящий из узлов, каждый из которых 
             * хранит ссылки на следующий и предыдущий узлы. 
             * сли ссылка на нужный узел уже есть (в нашем случае middleNode), 
             * вставка перед ним требует всего двух операций - 
             * перестановки указателей у соседних узлов. 
             * Это происходит мгновенно (O(1)) независимо от размера списка.
             * 
             * Но у LinkedList есть слабое место — поиск по индексу. 
             * Если вызвать linkedList.ElementAt(50000), придётся 
             * пробежать 50 000 узлов от начала, чтобы добраться до нужного. 
             * В List доступ по индексу мгновенный (arr[50000]), поскольку массив хранится в памяти непрерывно.
             */
        }
    }
}
