using Moq;

namespace AirportDataSearch.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string line = "bo";
            var file = new Mock<IFileSystem>();
            var display = new Mock<IView>();
            var sut = new Searcher(file.Object, display.Object);

            sut.Find();

        }
    }
}
