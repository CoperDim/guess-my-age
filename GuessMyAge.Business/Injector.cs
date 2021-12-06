using Microsoft.Extensions.DependencyInjection;

namespace GuessMyAge.Business
{
    public static class Injector
    {
        public static IServiceCollection Inject(this IServiceCollection serviceCollection)
        {

            return serviceCollection;
        }
    }
}
