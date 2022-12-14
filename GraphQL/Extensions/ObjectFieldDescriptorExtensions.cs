using Microsoft.EntityFrameworkCore;

using HotChocolate.Types;

namespace GraphQL.Extensions;

public static class ObjectFieldDescriptorExtensions
{
    public static IObjectFieldDescriptor UseDbContext<TDbContext>(
        this IObjectFieldDescriptor descriptor) where TDbContext: DbContext
    {
        return descriptor.UseScopedService<TDbContext>(
            create: services => services.GetRequiredService<IDbContextFactory<TDbContext>>().CreateDbContext(),
            disposeAsync: (service, context) => context.DisposeAsync());
    }
}
