using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public interface IView
    {
        void Show(IEnumerable<IGrouping<string, string>> searchResult,
            Stopwatch sw);
    }
}
