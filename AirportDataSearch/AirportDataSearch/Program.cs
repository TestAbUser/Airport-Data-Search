using AirportDataSearch;
using System.Diagnostics;
using System.IO;

namespace AirportDataSearch
{
    public class Program
    {
        private static readonly Searcher? _searcher=  new Searcher() ;
        private static IFileSystem? _file = new FileSystem();
       private static Stopwatch sw = Stopwatch.StartNew();
        static string path = Path.Combine(Environment.CurrentDirectory, "airports.dat");

        public Program()
        { }
        
        public static void Main(string[]args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            //To Do: check that command line parameter not bigger than number of columns
            _= int.TryParse(args[0], out int result);
            _searcher!.ColumnIndex = result;
           // Searcher searcher = new() { ColumnIndex = result};

           // IFileSystem fileSystem = new FileSystem();
           // var lines = fileSystem.ReadLines(path);

       Program program = new Program(); 
            
            
         program.StartSearch(GetSearchInput());
        }

        private static string[] GetFileContent()
        {
           return  _file!.ReadLines(path);
        }

        string[] file = GetFileContent();

       public void StartSearch(string? searchedString)
        {
            while (searchedString != "!quit")
            {
                sw.Start();
                var searchResult =_searcher!.Find(searchedString, ref file);
                sw.Stop();
                IView displayer = new Displayer();
                displayer.Show(searchResult, sw);
                sw.Reset();
                searchedString = GetSearchInput();
            }
        }

        private static string? GetSearchInput()
        {
            Console.WriteLine("Введите строку:");
            return Console.ReadLine();
        }
    }
}
