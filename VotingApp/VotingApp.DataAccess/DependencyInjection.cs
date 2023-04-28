using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VotingApp.DataAccess.EntityFramework;
using VotingApp.DataAccess.EntityFramework.Contexts;
using VotingApp.DataAccess.Interfaces;

namespace VotingApp.DataAccess;
public static class DependencyInjection {
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration) {

        services.AddDbContext<VotingDbContext>(options => {
            options.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
        });

        services.AddScoped<IOptionRepository, EfOptionRepository>();
        services.AddScoped<IPollRepository, EfPollRepository>();
        services.AddScoped<IUserRepository, EfUserRepository>();
        services.AddScoped<IVoteRepository, EfVoteRepository>();
        return services;
    }
}