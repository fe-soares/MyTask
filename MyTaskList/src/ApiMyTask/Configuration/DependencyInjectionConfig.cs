using Dev.Business.Interfaces;
using Dev.Business.Notificacoes;
using Dev.Data.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMyTask.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection service)
        {
            service.AddScoped<EfContext>();

            service.AddScoped<INotificador, Notificador>();

            return service;
        }
    }
}
