using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public class Search
    {
        private readonly IFileSystem _file;

        public Search(IFileSystem file)
        {
            ArgumentNullException.ThrowIfNull(file, nameof(file));
            _file = file;
        }
    }
}
