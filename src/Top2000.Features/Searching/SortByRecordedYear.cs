namespace Top2000.Features.Searching;

public class SortByRecordedYear : ISort
{
    public IOrderedEnumerable<Track> Sort(IEnumerable<Track> tracks)
        => tracks.OrderBy(x => x.RecordedYear);
}
