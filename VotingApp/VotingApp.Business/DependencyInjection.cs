using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VotingApp.Business.Services;
using VotingApp.DataAccess;

namespace VotingApp.Business;
public static class DependencyInjection {
    public static IServiceCollection AddBusinessLayer(this IServiceCollection services, IConfiguration configuration) {
        services.AddDataAccessLayer(configuration);

        services.AddScoped<IPollService, PollService>();
        return services;
    }
}