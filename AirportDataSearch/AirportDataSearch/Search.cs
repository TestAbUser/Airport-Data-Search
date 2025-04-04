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
        private readonly IDisplay _display;

        public Search(IFileSystem file, IDisplay display)
        {
            ArgumentNullException.ThrowIfNull(file, nameof(file));
            ArgumentNullException.ThrowIfNull(display, nameof(display));
            _file = file;
            _display = display;
        }
    }
}
