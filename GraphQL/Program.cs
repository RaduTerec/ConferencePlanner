using Microsoft.EntityFrameworkCore;

using GraphQL.DataLoader;
using GraphQL.Persistance;
using GraphQL.Services;
using GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options => options.UseSqlite("Data Source=conferences.db"));

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>()
                .AddType<SpeakerType>()
                .AddDataLoader<SpeakerByIdDataLoader>()
                .AddDataLoader<SessionByIdDataLoader>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(ep =>
{
    ep.MapGraphQL();
});

app.Run();
