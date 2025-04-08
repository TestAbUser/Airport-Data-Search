namespace AirportDataSearch
{
    public class FileSystem: IFileSystem
    {
        public string[] ReadLines(string path)
        {
            ArgumentException.ThrowIfNullOrEmpty(path, nameof(path));
          
           return File.ReadAllLines(path);
        }
    }
}
