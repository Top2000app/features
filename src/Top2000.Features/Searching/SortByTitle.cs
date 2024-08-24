namespace Top2000.Features.Searching;

public class SortByTitle : ISort
{
    public IOrderedEnumerable<Track> Sort(IEnumerable<Track> tracks)
        => tracks.OrderBy(x => x.Title);
}
