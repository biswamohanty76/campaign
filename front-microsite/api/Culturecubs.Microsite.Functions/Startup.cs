using Culturecubs.Microsite.DataAccess.DataContext;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using Culturecubs.Microsite.DataAccess.Repository;


[assembly: FunctionsStartup(typeof(Culturecubs.Microsite.Functions.Startup))]
namespace Culturecubs.Microsite.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = Environment.GetEnvironmentVariable("ConnectionString", EnvironmentVariableTarget.Process);
            builder.Services.AddDbContext<ApplicationDbContext>(x =>
            {
                x.UseSqlServer(connectionString, options => options.EnableRetryOnFailure());
              
            });

            builder.Services.AddTransient<ITenantContestRepository, TenantContestRepository>();
            builder.Services.AddTransient<IThemeConfigurationRepository, ThemeConfigurationRepository>();
            builder.Services.AddTransient<ICanidateRegistrationRepository, CanidateRegistrationRepository>();
        }
    }
}
