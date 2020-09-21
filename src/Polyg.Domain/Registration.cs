using Microsoft.Extensions.DependencyInjection;
using Polyg.Common.Domain;
using Polyg.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Domain
{
    public static class Registration
    {
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthUserRepository, AuthUserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
