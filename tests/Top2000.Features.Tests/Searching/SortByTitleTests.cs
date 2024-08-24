using Top2000.Features.Searching;

namespace Top2000.Features.Tests.Searching;

[TestClass]
public class SortByTitleTests
{
    [TestMethod]
    public void SortByTitleSortTheTracksTitleAlphabetically()
    {
        var trackA = new Track { Title = "A" };
        var trackB = new Track { Title = "B" };
        var trackC = new Track { Title = "C" };
        var trackD = new Track { Title = "D" };

        var tracks = new[] { trackB, trackD, trackC, trackA };

        var actual = new SortByTitle().Sort(tracks);
        var expected = new[] { trackA, trackB, trackC, trackD };

        actual.Should().NotBeEmpty()
            .And.HaveCount(4)
            .And.ContainInOrder(expected);
    }
}
