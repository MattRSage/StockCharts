using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StockCharts.Modules.Stocks.Core;
using StockCharts.Shared.Abstractions.Modules;

namespace StockCharts.Modules.Stocks.Api;

public class StocksModule : IModule
{
    public string Name { get; } = "Stocks";

    public void Register(IServiceCollection services)
    {
        services.AddCore();
    }

    public void Use(IApplicationBuilder app)
    {
        
    }
}