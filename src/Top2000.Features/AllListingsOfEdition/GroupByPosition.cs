namespace Top2000.Features.AllListingsOfEdition;

public static class GroupExtensions
{
    public static IEnumerable<IGrouping<string, TrackListing>> GroupByPosition(this IEnumerable<TrackListing> tracks)
    {
        var count = tracks.Count();

        return tracks.GroupBy(x => Position(x, count));
    }

    private static string Position(TrackListing listing, int countOfItems)
    {
        const int GroupSize = 100;

        if (listing.Position < 100)
        {
            return "1 - 100";
        }

        if (countOfItems > 2000)
        {
            if (listing.Position >= 2400)
            {
                return "2400 - 2500";
            }
        }
        else
        {
            if (listing.Position >= 1900)
            {
                return "1900 - 2000";
            }
        }

        var min = listing.Position / GroupSize * GroupSize;
        var max = min + GroupSize;

        return $"{min} - {max}";
    }
}
