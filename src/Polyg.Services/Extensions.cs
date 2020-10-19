using Microsoft.Extensions.DependencyInjection;
using Polyg.Common.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Services
{
    public static class Extensions
    {
        public static void RegisterBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthUserService, AuthUserService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IPhraseService, PhraseService>();
        }
    }
}
