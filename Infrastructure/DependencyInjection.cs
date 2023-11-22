﻿using Dapper;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PSPublicMessagingAPI.Application.Abstractions.Clock;
using PSPublicMessagingAPI.Application.Abstractions.Data;
using PSPublicMessagingAPI.Domain.Abstractions;
using PSPublicMessagingAPI.Domain.ClientActions;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.PossibleActions;
using PSPublicMessagingAPI.Infrastructure.Clock;
using PSPublicMessagingAPI.Infrastructure.Data;
using PSPublicMessagingAPI.Infrastructure.Repositories;

namespace PSPublicMessagingAPI.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();

       

        var connectionString =
            configuration.GetConnectionString("Database") ??
            throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        services.AddScoped<INotificationRepository, NotificationRepository>();

        services.AddScoped<IClientActionRepository, ClientActionRepository>();

        services.AddScoped<IPossibleActionRepository, PossibleActionRepository>();

        services.AddScoped<IUnitOfWork>(sp => sp.GetRequiredService<ApplicationDbContext>());

        services.AddSingleton<ISqlConnectionFactory>(_ =>
            new SqlConnectionFactory(connectionString));

        SqlMapper.AddTypeHandler(new DateOnlyTypeHandler());

        return services;
    }
}