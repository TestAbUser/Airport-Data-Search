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
        IEnumerable<IGrouping<string, string>> Find(
            string searchString, 
            ref IOrderedEnumerable<IGrouping<string, string>> fileContent);
    }
}
