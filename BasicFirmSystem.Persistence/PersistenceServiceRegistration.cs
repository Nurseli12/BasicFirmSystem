using BasicFirmSystem.Persistence.Contexts;
using BasicFirmSystem.Persistence.Repositories;
using BasicFirmSystem.Persistence.Repositories.EntityRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFirmSystem.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("TemplateProjectConnectionString")));
            services.AddScoped<ICurrentCardRepository, CurrentCardRepository>();
            //services.AddSingleton<ICurrentCardRepository, CurrentCardRepository>();

            return services;
        }
    }
}
