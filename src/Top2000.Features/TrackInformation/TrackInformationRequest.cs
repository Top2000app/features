namespace Top2000.Features.TrackInformation;

public class TrackInformationRequest : IRequest<TrackDetails>
{
    public TrackInformationRequest(int trackId)
    {
        TrackId = trackId;
    }

    public int TrackId { get; }
}
