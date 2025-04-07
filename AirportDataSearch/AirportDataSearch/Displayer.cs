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
            foreach (var value in res)
            {
                foreach (var item in value)
                {
                    Console.Write($"{value.Key} ");
                    Console.WriteLine($"[{item}]");
                }
            }

            Console.WriteLine($"Количество найденных строк: {res.Count()}");
            Console.WriteLine($"Время затраченное на поиск: {sw.Elapsed.Milliseconds} мс.");
            Console.WriteLine();
        }
    }
}