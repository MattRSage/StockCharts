using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using StockCharts.Modules.Stocks.Core.Stocks.Repositories;
using StockCharts.Modules.Stocks.Infrastructure.EF;
using StockCharts.Modules.Stocks.Infrastructure.EF.Repositories;
using StockCharts.Shared.Infrastructure.Postgres;

[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Api")]

namespace StockCharts.Modules.Stocks.Infrastructure;

internal static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services
            .AddScoped<IStockRepository, StockRepository>()
            .AddPostgres<StocksDbContext>()
            .AddUnitOfWork<StocksUnitOfWork>();;
    }
}