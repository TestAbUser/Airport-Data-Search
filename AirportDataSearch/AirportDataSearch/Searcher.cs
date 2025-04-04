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
        private readonly IView _display;

        public Searcher(IFileSystem file, IView display)
        {
            ArgumentNullException.ThrowIfNull(file, nameof(file));
            ArgumentNullException.ThrowIfNull(display, nameof(display));
            _file = file;
            _display = display;
        }

        public void Find()
        {

        }
    }
}
