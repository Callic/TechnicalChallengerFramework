using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalChallengeLibrary;
using TechnicalChallengeLibrary.Interfaces;

namespace TechnicalChallengeAPI.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        /// <summary>
        /// Configure dependency injection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigDI(this IServiceCollection services)
        {
            services.AddScoped<IMain, Main>();
            return services;
        }
    }
}
