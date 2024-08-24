using System.Collections.ObjectModel;

namespace Top2000.Features.Searching;

public class SearchTrackRequest : IRequest<ReadOnlyCollection<IGrouping<string, Track>>>
{
    public SearchTrackRequest(string queryString, int latestYear, ISort sorting, IGroup group)
    {
        QueryString = queryString;
        this.LatestYear = latestYear;
        this.Sorting = sorting;
        this.Grouping = group;
    }

    public string QueryString { get; }
    public int LatestYear { get; }
    public ISort Sorting { get; set; }

    public IGroup Grouping { get; set; }
}