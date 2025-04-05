using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public class FileSystem: IFileSystem
    {
        //private readonly string _path;

        public required string Path { get; init;}
        public string[] ReadLines(string path)
        {
            ArgumentException.ThrowIfNullOrEmpty(path, nameof(path));
          
           return File.ReadAllLines(path);
        }
    }
}
