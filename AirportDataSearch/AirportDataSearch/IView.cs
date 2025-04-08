using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AirportDataSearch
{
    public interface IView
    {
        void Show(IEnumerable<IGrouping<string, string>> searchResult,
            Stopwatch sw);
    }
}
