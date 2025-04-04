using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public interface IFileSystem
    {
        string[] ReadFile(string path);
    }
}
