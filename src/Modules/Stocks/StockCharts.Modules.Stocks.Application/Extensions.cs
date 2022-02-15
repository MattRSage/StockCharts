using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Api")]
[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Infrastructure")]

namespace StockCharts.Modules.Stocks.Application;

internal static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}