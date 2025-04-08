using System.Text.RegularExpressions;

namespace AirportDataSearch
{
    public class Searcher : ISearch
    {
        public int ColumnIndex { get; set; }
        public IEnumerable<IGrouping<string, string>> Find(
            string searchString,
            ref IOrderedEnumerable<IGrouping<string, string>> fileContent)
        {
            var parsedFile = fileContent;
            var result = parsedFile.Where(
                x => Regex.IsMatch(x.Key, "^\"?" +
                Regex.Escape(searchString), RegexOptions.IgnoreCase));
            return result;
        }

        public IOrderedEnumerable<IGrouping<string, string>> ParseFile(string[] fileContent)
        {
            Regex regex = new(@"^[-+]?[0-9]*\.[0-9]+$");
            Lookup<string, string> result =
                (Lookup<string, string>)fileContent.ToLookup(x =>
                x.Split(',')[ColumnIndex - 1], x => x);// comma is not enough


            if (result.Any(x => regex.IsMatch(x.Key)))
            {
                var sorted = 
            result.Where(x => x.Key.All(y => char.IsDigit(y) || y == '.' || y == '-'))
            .OrderBy(z => double.Parse(z.Key))
            .Union(result.Where(d => d.Key.Any(f => char.IsLetter(f))))
            .OrderBy(x => x.Key);
                return sorted;
            }

            else if (result.Any(x => x.Key.All(x => char.IsDigit(x) || x == '-')))
            {
                return result.OrderBy(x => int.Parse(x.Key))
                             .Union(result.Where(d => d.Key.Any(f => char.IsLetter(f))))
                             .OrderBy(x => x.Key);
            }

            else
                return result.OrderBy(x => x.Key);
        }
    }
}
