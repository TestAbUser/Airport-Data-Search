using Moq;

namespace AirportDataSearch.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var file = new Mock<IFileSystem>();
            var display = new Mock<IDisplay>();
            var sut = new Search(file.Object, display.Object);



        }
    }
}
