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
        public void Show(IOrderedEnumerable<IGrouping<string, string>> res, 
            Stopwatch sw)
        {
            int count = 0;
            foreach (var value in res)
            {
                foreach (var item in value)
                {
                    Console.Write($"{value.Key} ");
                    Console.WriteLine($"[{item}]");
                    count++;
                }
            }

            Console.WriteLine($"Количество найденных строк: {count}");
            Console.WriteLine($"Время затраченное на поиск: {sw.Elapsed.Milliseconds} мс");
            Console.WriteLine();
        }
    }
}