using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PracticeApp.Business.Layer.Implementation;
using PracticeApp.Business.Layer.Interfaces;
using PracticeApp.Encryption.Implementation;
using PracticeApp.Encryption.Interface;
using PracticeApp.Entity.Layer.Entities;
using PracticeApp.Entity.Layer.Infrastructure.Interface;
using PracticeApp.Service.Layer.Implementation;
using PracticeApp.Service.Layer.Interfaces;

namespace PracticeApp.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IMasterBusiness, MasterBusiness>();
            return services;
        }
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IMasterService, MasterService>();
            return services;
        }
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MatrimonyCoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MatrimonyCore"),
                b => b.MigrationsAssembly(typeof(MatrimonyCoreContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddTransient<IApplicationDBContext>(provider => provider.GetService<MatrimonyCoreContext>());
            return services;
        }
        public static IServiceCollection AddEncryptionDependencies(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IPasswordHasher, PasswordHasher>();
            return services;
        }
    }
}
