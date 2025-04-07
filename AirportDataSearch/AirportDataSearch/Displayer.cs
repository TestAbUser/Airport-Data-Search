using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public class Displayer : IView
    {
        public void Show(IOrderedEnumerable<IGrouping<string, string>> foundLines, 
            Stopwatch sw)
        {
            int count = 0;
            foreach (var line in foundLines)
            {
                foreach (var value in line)
                {
                    Console.Write($"{line.Key} ");
                    Console.WriteLine($"[{value}]");
                    count++;
                }
            }

            Console.WriteLine($"Количество найденных строк: {count}");
            Console.WriteLine($"Время затраченное на поиск: {sw.Elapsed.Milliseconds} мс");
            Console.WriteLine();
        }
    }
}