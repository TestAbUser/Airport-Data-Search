using System.Globalization;
using System.Text.RegularExpressions;

namespace AirportDataSearch
{
    public class Searcher : ISearch
    {
        public int ColumnIndex { get; set; }
        public IEnumerable<IGrouping<string, string>> Find(
            string searchString, 
            ref IOrderedEnumerable<IGrouping<string, string>> fileContent/*string[] fileContent*/)
        {
            var parsedFile = fileContent;//ParseFile(fileContent);
            if (parsedFile.First().Key.StartsWith("\""))
                searchString = "\"" + searchString;
            var result = parsedFile.Where(x => x.Key.StartsWith(
                searchString, ignoreCase: true, culture: CultureInfo.CurrentCulture));
                //.OrderBy(x => x.Key);

            return result;
        }

        public IOrderedEnumerable<IGrouping<string, string>> ParseFile(string[] fileContent)
        {
            Regex regex = new("^[-+]?[0-9]*\\.[0-9]+$");
            Lookup<string, string> result =
                (Lookup<string, string>)fileContent.ToLookup(x =>
                x.Split(',')[ColumnIndex - 1], x => x);

            if(result.Any(x=>x.Key.StartsWith('"')&& x.Key.EndsWith('"')))
            {
                var sortedResult = result.OrderBy(x => x.Key);
                return sortedResult;
            }
               
            else if (result.Any(x =>regex.IsMatch(x.Key)))
            {
                var sorted = result.OrderBy(x => double.TryParse(x.Key, out double _));
            return sorted;
            }
                
           else return result.OrderBy(x => int.Parse(x.Key));
               // return result;
        }
    }
}
