using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public class Searcher: ISearch
    {
        public int ColumnIndex { get; set; }
        public IOrderedEnumerable<IGrouping<string,string>> Find(
            string? searchString, ref string[] fileContent)
        {
            var parsedFile = ParseFileContent(fileContent);
            var result = parsedFile.Where(x =>
             x.Key.StartsWith("\""+searchString)).OrderBy(x=>x.Key);

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
