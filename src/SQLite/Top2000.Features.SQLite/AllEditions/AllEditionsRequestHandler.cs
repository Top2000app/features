using Top2000.Features.AllEditions;

namespace Top2000.Features.SQLite.AllEditions;

public class AllEditionsRequestHandler : IRequestHandler<AllEditionsRequest, ImmutableSortedSet<Edition>>
{
    private readonly SQLiteAsyncConnection connection;

    public AllEditionsRequestHandler(SQLiteAsyncConnection connection)
    {
        this.connection = connection;
    }

    public async Task<ImmutableSortedSet<Edition>> Handle(AllEditionsRequest request, CancellationToken cancellationToken)
    {
        var result = await connection
            .Table<Edition>()
            .ToListAsync();

        return result.ToImmutableSortedSet(new EditionDescendingComparer());
    }
}
