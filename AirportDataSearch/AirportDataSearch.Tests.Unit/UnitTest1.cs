using Moq;

namespace AirportDataSearch.Tests.Unit
{
    public class UnitTest1
    {
        [Fact]
        public void Matching_results_are_displayed_for_the_searched_value()
        {
            const string Line = "bo";
            const string Path = "test";
            var file = new Mock<IFileSystem>();
            var display = new Mock<IView>();

            file.Setup(x => x.ReadFile(Path)).Returns(
                [
                ["1","Goroka Airport","Goroka"],
                ["7","Narsarsuaq Airport","Narssarssuaq"]
                ]);


            var sut = new Searcher(file.Object, display.Object);

            var result = sut.Find(Line);

            // Assert.Equal([["7", "Narsarsuaq Airport", "Narssarssuaq"]], result);

        }
    }
}
