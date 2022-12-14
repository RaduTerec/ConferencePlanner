using GraphQL.Extensions;
using GraphQL.Models;
using GraphQL.Persistance;
using GraphQL.Services.Speakers;

using HotChocolate;

namespace GraphQL.Services;

public class Mutation
{
    [UseApplicationDbContext]
    public async Task<AddSpeakerPayload> AddSpeakerAsync(
        AddSpeakerInput input,
        [ScopedService] ApplicationDbContext context)
    {
        var speaker = new Speaker
        {
            Name = input.Name,
            Bio = input.Bio,
            WebSite = input.WebSite
        };

        await context.Speakers.AddAsync(speaker);
        await context.SaveChangesAsync();

        return new AddSpeakerPayload(speaker);
    }
}
