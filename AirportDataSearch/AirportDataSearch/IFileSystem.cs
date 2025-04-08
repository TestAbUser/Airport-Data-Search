
namespace AirportDataSearch
{
    public interface IFileSystem
    {
        string[] ReadLines(string path);
    }
}
