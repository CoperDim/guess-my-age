using GuessMyAge.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GuessMyAge.Database
{
    public static class Injector
    {
        public static IServiceCollection InjectRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPersonRepository, PersonRepository>();

            return serviceCollection;
        }
    }
}
