﻿using System.Reflection;
using CaWorkshop.Application.Common.Behaviours;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CaWorkshop.Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(Assembly.GetExecutingAssembly());

        services.AddTransient(typeof(IPipelineBehavior<,>),
            typeof(ValidationBehaviour<,>));

        return services;
    }
}
