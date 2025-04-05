using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public interface IFileSystem
    {
        string Path { get; init; }
        string[] ReadLines(string path);
    }
}
