using GuessMyAge.Business.Services;
using Microsoft.Extensions.DependencyInjection;

namespace GuessMyAge.Business
{
    public static class Injector
    {
        public static IServiceCollection Inject(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPersonService, PersonService>();
            serviceCollection.AddTransient<IGameService, GameService>();

            return serviceCollection;
        }
    }
}
