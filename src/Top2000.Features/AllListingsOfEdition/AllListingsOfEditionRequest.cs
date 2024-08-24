namespace Top2000.Features.AllListingsOfEdition;

public class AllListingsOfEditionRequest : IRequest<ImmutableHashSet<TrackListing>>
{
    public AllListingsOfEditionRequest(int year)
    {
        Year = year;
    }

    public int Year { get; }
}
