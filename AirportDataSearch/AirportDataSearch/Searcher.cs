using System.Globalization;

namespace AirportDataSearch
{
    public class Searcher : ISearch
    {
        public int ColumnIndex { get; set; }
        public IOrderedEnumerable<IGrouping<string, string>> Find(
            string searchString, ref Lookup<string, string> fileContent/*string[] fileContent*/)
        {
            var parsedFile = fileContent;//ParseFile(fileContent);
            if (parsedFile.First().Key.StartsWith("\""))
                searchString = "\"" + searchString;
            var result = parsedFile.Where(x => x.Key.StartsWith(
                searchString, ignoreCase: true, culture: CultureInfo.CurrentCulture))
                .OrderBy(x => x.Key);

            return result;
        }

        public Lookup<string, string> ParseFile(string[] fileContent)
        {
            Lookup<string, string> result =
                (Lookup<string, string>)fileContent.ToLookup(x =>
                x.Split(',')[ColumnIndex - 1], x => x);
            return result;
        }
    }
}
