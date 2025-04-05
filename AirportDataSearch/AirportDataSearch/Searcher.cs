using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public class Searcher
    {
        private readonly IFileSystem _file;

        public Searcher(IFileSystem file)
        {
            ArgumentNullException.ThrowIfNull(file, nameof(file));
            _file = file;
        }

        public List<string[]> Find(string searchedLine)
        {
            return new List<string[]>();

        }

        //private string[] ParseCsv()
        //{
        //    _file.ReadLines(_file.Path);

        //    return _file.ReadLines(_file.Path);
        //}
    }
}
