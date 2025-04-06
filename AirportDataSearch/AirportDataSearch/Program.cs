using AirportDataSearch;

namespace AirportDataSearch
{
    public static class Program
    {
        public static void Main(string[]args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "airports.dat");

            IFileSystem fileSystem = new FileSystem();

            _= int.TryParse(args[0], out int result);
            Searcher searcher = new() { ColumnIndex = result};

            var lines = fileSystem.ReadLines(path);
            searcher.Find("Bo", lines);

            IView displayer = new Displayer();

            displayer.Show(lines);

            Console.ReadLine();
            //Searcher searcher = new Searcher()
        }
    }
}
