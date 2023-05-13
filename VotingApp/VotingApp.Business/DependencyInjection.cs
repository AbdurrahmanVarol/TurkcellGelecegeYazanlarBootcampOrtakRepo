using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using VotingApp.Business.Services;
using VotingApp.DataAccess;

namespace VotingApp.Business;
public static class DependencyInjection {
    public static IServiceCollection AddBusinessLayer(this IServiceCollection services, IConfiguration configuration) {
        
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IVoteService,VoteService>();
        services.AddScoped<IPollService, PollService>();
        return services;
    }
}