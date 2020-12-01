using Erecruta.Interface;
using Erecruta.Repository;
using Erecruta.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Erecruta.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static IServiceCollection ConfigurarDependencias(this IServiceCollection services)
        {
            services.AddSingleton<IOportunidadeService, OportunidadeService>();
            services.AddSingleton<IOportunidadeRepository, OportunidadeRepository>();
            services.AddSingleton<ICandidatoService, CandidatoService>();
            services.AddSingleton<ICandidatoRepository, CandidatoRepository>();
            services.AddSingleton<INivelRepository, NivelRepository>();
            services.AddSingleton<IOportunidadeNivelRepository, OportunidadeNivelRepository>();
            services.AddSingleton<IIBGERepository, IBGERepository>();
            services.AddSingleton<IIBGEService, IBGEService>();

            return services;
        }
    }
}
