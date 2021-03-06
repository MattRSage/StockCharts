using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Api")]
[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Application")]
[assembly: InternalsVisibleTo("StockCharts.Modules.Stocks.Infrastructure")]

namespace StockCharts.Modules.Stocks.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services;
    }
}