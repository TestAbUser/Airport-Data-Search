using AirportDataSearch;
string path = Path.Combine(Environment.CurrentDirectory,"airports.dat");

IFileSystem fileSystem =new FileSystem();
var result =fileSystem.ReadLines(path);
Console.WriteLine(result);
Console.ReadLine();
//Searcher searcher = new Searcher()
