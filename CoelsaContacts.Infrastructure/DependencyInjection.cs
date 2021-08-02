using Microsoft.Extensions.DependencyInjection;
using CoelsaContacts.Application.Contracts;
using CoelsaContacts.Infrastructure.Repositories;

namespace CoelsaContacts.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
