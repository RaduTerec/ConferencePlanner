using Microsoft.EntityFrameworkCore;

using GraphQL.DataLoader;
using GraphQL.Extensions;
using GraphQL.Models;
using GraphQL.Persistance;

namespace GraphQL.Services;

public sealed class Query
{
    [UseApplicationDbContext]
    public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
        context.Speakers.ToListAsync();

    public Task<Speaker> GetSpeakerAsync(
        int id,
        SpeakerByIdDataLoader dataLoader,
        CancellationToken cancellationToken) =>
    dataLoader.LoadAsync(id, cancellationToken);
}