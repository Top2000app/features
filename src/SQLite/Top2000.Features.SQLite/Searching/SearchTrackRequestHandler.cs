using System.Collections.ObjectModel;
using MoreLinq;
using Top2000.Features.Searching;

namespace Top2000.Features.SQLite.Searching;

public class SearchTrackRequestHandler : IRequestHandler<SearchTrackRequest, ReadOnlyCollection<IGrouping<string, Track>>>
{
    private readonly SQLiteAsyncConnection connection;

    public SearchTrackRequestHandler(SQLiteAsyncConnection connection)
    {
        this.connection = connection;
    }

    public async Task<ReadOnlyCollection<IGrouping<string, Track>>> Handle(SearchTrackRequest request, CancellationToken cancellationToken)
    {
        var results = new List<Track>();

        if (!string.IsNullOrWhiteSpace(request.QueryString))
        {
            if (int.TryParse(request.QueryString, out var year))
            {
                var sql = "SELECT Id, Title, Artist, RecordedYear, Listing.Position AS Position " +
                    "FROM Track " +
                    "LEFT JOIN Listing ON Track.Id = Listing.TrackId AND Listing.Edition = 2023 " +
                    "WHERE RecordedYear = ?" +
                    "LIMIT 100";

                results = await connection.QueryAsync<Track>(sql, year);
            }
            else
            {
                var sql = "SELECT Id, Title, Artist, RecordedYear, Listing.Position AS Position " +
                    "FROM Track " +
                    "LEFT JOIN Listing ON Track.Id = Listing.TrackId AND Listing.Edition = 2023 " +
                    "WHERE (Title LIKE ?) OR (Artist LIKE ?)" +
                    "LIMIT 100";

                results = await connection.QueryAsync<Track>(sql, $"%{request.QueryString}%", $"%{request.QueryString}%");
            }
        }

        results.ForEach(x => x.LatestEdition = request.LatestYear);
        var sorted = request.Sorting.Sort(results);
        var groupedAndSorted = request.Grouping.Group(sorted).ToList();

        return groupedAndSorted.AsReadOnly();
    }
}
