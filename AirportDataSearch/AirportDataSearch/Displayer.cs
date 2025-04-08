using System.Diagnostics;

namespace AirportDataSearch
{
    public class Displayer : IView
    {
        public void Show(IEnumerable<IGrouping<string, string>> foundLines,
            Stopwatch? sw=default)
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
            Console.WriteLine($"Время затраченное на поиск: {sw?.Elapsed.Milliseconds} мс");
            Console.WriteLine();
        }
    }
}