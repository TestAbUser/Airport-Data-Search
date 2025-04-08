
namespace AirportDataSearch
{
    public interface ISearch
    {
         int ColumnIndex { get; set; }
        IEnumerable<IGrouping<string, string>> Find(
            string searchString, 
            ref IEnumerable<IGrouping<string, string>> fileContent);
    }
}
