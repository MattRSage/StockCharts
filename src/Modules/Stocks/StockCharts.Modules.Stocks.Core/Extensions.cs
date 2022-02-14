using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using StockCharts.Modules.Stocks.Core.DAL;
using StockCharts.Modules.Stocks.Core.DAL.Repositories;
using StockCharts.Modules.Stocks.Core.Repositories;
using StockCharts.Shared.Infrastructure.Postgres;


[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Api")]

namespace StockCharts.Modules.Stocks.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services
            .AddScoped<IStockRepository, StockRepository>()
            .AddPostgres<StocksDbContext>()
            .AddUnitOfWork<StocksUnitOfWork>();
    }
}