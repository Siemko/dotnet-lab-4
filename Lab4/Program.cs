using System;
using System.Collections.Generic;
using System.Linq;
using Lab4.Helpers;
using Lab4.Models;

namespace Lab4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var n1 = new[] {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};
            var result = from n in n1 where n % 2 == 0 select n;
            TaskWriterHelper.WriteResult(result, 1);

            var arr1 = new[] {3, 9, 2, 8, 6, 5};
            result = from n in arr1 where n > 0 && n < 12 select n;
            TaskWriterHelper.WriteResult(result, 2);

            var input = Enumerable.Range(0, (int) Math.Sqrt(int.MaxValue)).ToArray();
            result = from n in input where n * n > 20 select n;
            TaskWriterHelper.WriteResult(result, 3);

            arr1 = new[] {5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2};
            var res = arr1.GroupBy(x => x)
                .Select(x => new {Key = (char) x.Key, Count = x.Count()}).ToArray();
            TaskWriterHelper.WriteDictionaryResult(res, 4);

            const string str = "abeddwkkecjjeksoiekcllkenndkwel";
            var res2 = str.GroupBy(x => x)
                .Select(x => new {x.Key, Count = x.Count()}).ToArray();
            TaskWriterHelper.WriteDictionaryResult(res, 5);

            string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };
            Console.WriteLine($"Wynik zadanie: 6");
            months.ToList().ForEach(Console.WriteLine);


            var nums = new[] {5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2};
            var res4 = nums.GroupBy(x => x)
                .Select(x => new {x.Key, Count = x.Count(), Distinct = x.Distinct(), Sum = x.Count() * x.Key})
                .ToArray();
            TaskWriterHelper.WriteDictionaryResult(res4, 7);


            string[] cities =
            {
                "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
            };
            Console.WriteLine("\nPodaj początkowy znak: ");
            var start = Console.ReadLine();
            Console.WriteLine("\nPodaj końcowy znak: ");
            var end = Console.ReadLine();
            var startChar = start.ToUpper()[0];
            var endChar = end.ToUpper()[0];
            var filtered = cities.Where(x => x[0] == startChar && x[x.Length - 1] == endChar).ToList();
            Console.WriteLine($"Wynik zadanie: 9");
            filtered.ForEach(f => Console.WriteLine($"{f}"));


            var listOfValues = new List<int>();
            Console.WriteLine("\nPodaj wartość i naciśnij enter: ");
            for (var i = 0; i < 5; i++)
                listOfValues.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\nPodaj wartość dla warunku większe od: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var greaterThanUserInput = listOfValues.FindAll(f => f > userInput);
            TaskWriterHelper.WriteResult(greaterThanUserInput, 10);


            listOfValues = new List<int> {1, 2, 3, 5, 8};
            Console.WriteLine("\nPodaj ile ostatnich wartości wyświetlić: ");
            var userInput2 = Convert.ToInt32(Console.ReadLine());
            listOfValues.Reverse();
            var lastValues = listOfValues.Take(userInput2);
            TaskWriterHelper.WriteResult(lastValues.Reverse(), 11);


            listOfValues = new List<int> {1, 2, 3, 5, 8};
            Console.WriteLine("\nPodaj ile największych wartości wyświetlić: ");
            var userInput3 = Convert.ToInt32(Console.ReadLine());
            listOfValues.Sort();
            listOfValues.Reverse();
            var maxValues = listOfValues.Take(userInput3);
            TaskWriterHelper.WriteResult(maxValues.Reverse(), 12);


            const string text = "Ala ma Dwa białe Koty";
            var splitted = text.Split(' ');
            var separated =
                (from n in splitted where n[0].ToString().Equals(n[0].ToString().ToUpper()) select n).ToList();
            Console.WriteLine("Zadanie 13, Wynik: {0}", string.Join(" ", separated));


            string[] tab = {"ala", "kot", "pies"};
            TaskWriterHelper.WriteResult(tab, 14);


            var students = new Students();
            var listOfStudents = students.GtStuRec();
            Console.WriteLine("\nPodaj n studentów: ");
            var userInput4 = Convert.ToInt32(Console.ReadLine());
            var filteredStudents = listOfStudents.OrderByDescending(s => s.GroupPoint);
            var filteredResult = filteredStudents.Take(userInput4);
            Console.WriteLine($"Zadanie: 15");
            filteredResult.ToList().ForEach(r => Console.WriteLine($"Wartość: {r.StudentName}. Ilość: {r.GroupPoint}"));


            string[] arr2 = {"a.erc", "b.txt", "c.ldd", "d.pdf", "e.PDF", "a.pdf", "b.xml", "z.txt", "zzz.doc"};
            for (var i = 0; i < arr2.Count(); i++)
                arr2[i] = arr2[i].Substring(arr2[i].IndexOf('.'), 4).ToLower();

            var ress = arr2.GroupBy(x => x)
                .Select(x => new {x.Key, Count = x.Count()}).ToArray();
            TaskWriterHelper.WriteDictionaryResult(ress, 16);


            var listOfValues2 = new List<int> {1, 2, 3};
            Console.WriteLine("\nPodaj wartosc do usuniecia: ");
            var userInput5 = Convert.ToInt32(Console.ReadLine());
            listOfValues2.Remove(userInput5);
            TaskWriterHelper.WriteResult(listOfValues2, 17);


            char[] charset1 = {'A', 'B', 'C', 'D'};
            int[] numset1 = {1, 2, 3, 4};
            var cartesianProduct = from x in charset1
                from y in numset1
                select new {x, y};
            Console.WriteLine("Zadanie 18 wynik: \n");
            foreach (var item in cartesianProduct)
                Console.WriteLine(item);


            var itemlist = new List<ItemMast>
            {
                new ItemMast {Id = 1, Descr = "A  "},
                new ItemMast {Id = 2, Descr = "B"},
                new ItemMast {Id = 3, Descr = "C"},
                new ItemMast {Id = 4, Descr = "D"},
                new ItemMast {Id = 5, Descr = "E"}
            };

            var purchlist = new List<Purchase>
            {
                new Purchase {No = 100, Id = 3, Qty = 55},
                new Purchase {No = 101, Id = 2, Qty = 44},
                new Purchase {No = 102, Id = 3, Qty = 555},
                new Purchase {No = 103, Id = 4, Qty = 33},
                new Purchase {No = 104, Id = 3, Qty = 33},
                new Purchase {No = 105, Id = 4, Qty = 44},
                new Purchase {No = 106, Id = 1, Qty = 343}
            };


            var innerJoin = from item in itemlist
                join purch in purchlist
                    on item.Id equals purch.Id
                select new
                {
                    item.Id,
                    Name = item.Descr,
                    purch.Qty
                };

            Console.WriteLine("Zadanie 19 wynik: \n");
            foreach (var item in innerJoin)
                Console.WriteLine(item);


            var leftJoin = from item in itemlist
                join purch in purchlist on item.Id equals purch.Id into temp
                from purch in temp.DefaultIfEmpty()
                select new
                {
                    item.Id,
                    item.Descr,
                    ProductNo = purch?.No ?? 0,
                    Qty = purch?.Qty ?? 0
                };

            Console.WriteLine("Zadanie 19 wynik: \n");
            foreach (var item in leftJoin)
                Console.WriteLine(item);


            var rightJoin = from purch in purchlist
                join item in itemlist
                    on purch.Id equals item.Id into joined
                from item in joined.DefaultIfEmpty()
                select new
                {
                    item.Id,
                    Description = item.Descr
                };


            Console.WriteLine("Zadanie 20 wynik: \n");
            foreach (var item in rightJoin)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}