using Microsoft.Extensions.DependencyInjection;
using System.Collections.Immutable;
using Top2000.Features.AllListingsOfEdition;

namespace Top2000.Features.Specs.Bindings;

[Binding]
public class AllListingsOfEditionSteps
{
    private ImmutableHashSet<TrackListing> result;

    [Then(@"an empty set is returned")]
    public void ThenAnEmptySetIsReturned()
    {
        result.Should().BeEmpty();
    }

    [When(@"the AllListingOfEdition feature is executed with year (.*)")]
    public async Task WhenTheAllListingOfEditionFeatureIsExecutedWithYear(int year)
    {
        var request = new AllListingsOfEditionRequest(year);
        var mediator = App.GetService<IMediator>();

        result = await mediator.Send(request);
    }
}
