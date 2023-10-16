using FSH.WebApi.Application.Common.Persistence;
using FSH.WebApi.Domain.Common.Contracts;
using FSH.WebApi.Infrastructure.Caching;
using FSH.WebApi.Infrastructure.Common;
using FSH.WebApi.Infrastructure.Persistence;
using FSH.WebApi.Infrastructure.Persistence.ConnectionString;
using FSH.WebApi.Infrastructure.Persistence.Context;
using FSH.WebApi.Infrastructure.Persistence.Initialization;
using FSH.WebApi.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Serilog;

namespace FSH.WebApi.Infrastructure.Gestion;

internal static class Startup
{
    private static readonly ILogger _logger = Log.ForContext(typeof(Startup));

    internal static IServiceCollection AddGestion(this IServiceCollection services, IConfiguration config)
    {
        var settings = config.GetSection(nameof(GestionSettings)).Get<GestionSettings>();

        return services
            .AddDbContext<GestionDbContext>((p, m) =>
            {
                m.UseDatabase(settings.ConnectionString);
            });

    }

    internal static DbContextOptionsBuilder UseDatabase(this DbContextOptionsBuilder builder, string connectionString)
    {
        return builder.UseSqlServer(connectionString);
    }
 }