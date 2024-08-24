using Top2000.Features.AllListingsOfEdition;

namespace Top2000.Features.Tests.AllListingsOfEdition;

[TestClass]
public class TrackListingTests
{
    [TestMethod]
    public void LocalStartDateAndTimeTransformsTheUtc()
    {
        var sut = new TrackListing
        {
            PlayUtcDateAndTime = DateTime.UtcNow
        };

        sut.LocalPlayDateAndTime.Should().BeCloseTo(DateTime.Now, TimeSpan.FromSeconds(1));
    }
}
