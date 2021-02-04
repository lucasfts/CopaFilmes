using AutoMapper;
using CopaFilmes.Application;
using CopaFilmes.Application.Mapper;
using CopaFilmes.Domain.Contracts;
using CopaFilmes.Infra.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CopaFilmes.CrossCutting.IoC
{
    public static class DependencyResolver
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IFilmeRepository, FilmeRepository>();

            var applicationAssemly = Assembly.Load("CopaFilmes.Application");
            services.AddAutoMapper(applicationAssemly);

            services.AddScoped<CopaService>();

            return services;
        }
    }
}
