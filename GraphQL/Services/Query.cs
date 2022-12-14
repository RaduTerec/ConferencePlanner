using Microsoft.EntityFrameworkCore;

using GraphQL.Extensions;
using GraphQL.Models;
using GraphQL.Persistance;

using HotChocolate;

namespace GraphQL.Services;

public sealed class Query
{
    [UseApplicationDbContext]
    public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
        context.Speakers.ToListAsync();
}