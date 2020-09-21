using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Polyg.Common.Infrastructure.Jwt;
using Polyg.Infrastructure.Jwt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Infrastructure
{
    public static class Extensions
    {
        public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtHandler, JwtHandler>();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                var validIssuer = "http://localhost";
                var secretKey = "AmNQ0itykVf7Dge3qdmq";
                var issuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidIssuer = validIssuer,
                    IssuerSigningKey = issuerSigningKey
                };
            });
        }

        public static void ConfigureJwtAuthentication(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();
        }
    }
}
