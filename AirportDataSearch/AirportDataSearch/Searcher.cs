using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public class Searcher
    {
        public int ColumnIndex { get; init; }
        public IOrderedEnumerable<IGrouping<string,string>> Find(
            string searchString, string[] fileContent)
        {
            var parsedFile = ParseFileContent(fileContent);
            var result = parsedFile.Where(x =>
             x.Key.StartsWith("\""+searchString)).OrderBy(x=>x.Key);
            //foreach (var value in res)
            //{
            //    foreach (var item in value)
            //    {
            //        Console.Write($"{value.Key} ");
            //        Console.WriteLine($"[{item}]");
            //    }
            //}
            
            //Console.WriteLine(res.Count());
           // Console.WriteLine(sw.Elapsed.Milliseconds);
           return result;
        }

        private Lookup<string,string> ParseFileContent(string[] fileContent)
        {

                Lookup<string, string> lookup =
                    (Lookup<string, string>)fileContent.ToLookup(x =>
                    x.Split(',')[ColumnIndex-1],x=>x );
            return lookup;
        }
    }
}
