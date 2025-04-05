using AirportDataSearch;

namespace AirportDataSearch
{
    public static class Program
    {
        public static void Main(string[]?args)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "airports.dat");

            IFileSystem fileSystem = new FileSystem();
            var result = fileSystem.ReadLines(path);
            IView displayer = new Displayer();

            displayer.Show(result);

            Console.ReadLine();
            //Searcher searcher = new Searcher()
        }
    }
}
