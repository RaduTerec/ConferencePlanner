using Microsoft.EntityFrameworkCore;

using GraphQL.Persistance;
using GraphQL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(options => options.UseSqlite("Data Source=conferences.db"));

builder.Services.AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(ep =>
{
    ep.MapGraphQL();
});

app.Run();
