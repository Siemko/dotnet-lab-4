using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskHelperLib
{
    public static class TaskWriterHelper
    {
        public static void WriteResult(IEnumerable<int> result, int taskNo)
        {
            Console.WriteLine($"Zadanie: {taskNo}");
            Console.WriteLine($"Wynik: {string.Join(",", result)}\n\n");
        }

        public static void WriteResult(string[] result, int taskNo)
        {
            Console.WriteLine($"Zadanie: {taskNo}");
            Console.WriteLine($"Wynik: {string.Join(",", result)}\n\n");
        }

        public static void WriteDictionaryResult(IEnumerable<dynamic> result, int taskNo)
        {
            Console.WriteLine($"Zadanie: {taskNo}");
            result.ToList().ForEach(r => Console.WriteLine($"Wartość: {r.Key}. Ilość: {r.Count}"));
        }


        public static void WriteDictionaryResult(IEnumerable<dynamic> result, string first, string last, int taskNo)
        {
            Console.WriteLine($"Zadanie: {taskNo}");
            result.ToList().ForEach(r => Console.WriteLine($"Wartość: {r[first]}. Ilość: {r[last]}"));
        }
    }
}