using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDataSearch
{
    public interface ISearch
    {
         int ColumnIndex { get; set; }
        IOrderedEnumerable<IGrouping<string, string>> Find(
            string? searchString, string[] fileContent);
    }
}
