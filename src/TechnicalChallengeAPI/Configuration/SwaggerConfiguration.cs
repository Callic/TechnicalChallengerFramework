using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;


namespace TechnicalChallengeAPI.Configuration
{
    public static class SwaggerConfiguration
    {
        public static IServiceCollection SwaggerConfig(this IServiceCollection services)
        {

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Technical Challenge Framework",
                    Description = "API de identidade da NerdStoreEnterprise",
                    Contact = new OpenApiContact { Name = "Gustavo Miranda", Email = "gustavocallic@gmail.com" },
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }

                });
            });
            return services;
        }
        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
            return app;
        }
    }
}
