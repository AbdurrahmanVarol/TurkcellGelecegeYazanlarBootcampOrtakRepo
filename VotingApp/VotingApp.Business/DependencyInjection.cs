using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VotingApp.DataAccess;

namespace VotingApp.Business;
public static class DependencyInjection {
    public static IServiceCollection AddBusinessLayer(this IServiceCollection services, IConfiguration configuration) {

        services.AddDataAccessLayer(configuration);
        return services;
    }
}