using AirportDataSearch;
using System.IO;

namespace AirportDataSearch
{
    public class Program
    {
        private static readonly Searcher? _searcher=  new Searcher() ;
        private static readonly IFileSystem? _file = new FileSystem();

       static string path = Path.Combine(Environment.CurrentDirectory, "airports.dat");

        public Program()
        { }
        
        public static void Main(string[]args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            

            _= int.TryParse(args[0], out int result);
            _searcher!.ColumnIndex = result;
           // Searcher searcher = new() { ColumnIndex = result};

           // IFileSystem fileSystem = new FileSystem();
           // var lines = fileSystem.ReadLines(path);

       Program program = new Program(); 

           program.StartSearch(GetSearchInput());
        

           // IView displayer = new Displayer();

           // displayer.Show(lines);

            Console.ReadLine();
            //Searcher searcher = new Searcher()
        }

        private static string[] GetFileContent()
        {
           return _file!.ReadLines(path);
        }

       public void StartSearch(string? searchedString)
        {
            while (searchedString != "!quit")
            {
                _searcher?.Find(searchedString, GetFileContent());
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
