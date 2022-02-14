using System.Reflection;
using StockCharts.Shared.Abstractions.Modules;
using StockCharts.Shared.Infrastructure;
using StockCharts.Shared.Infrastructure.Modules;

namespace StockCharts.Bootstrapper;

public class Startup
{
    private readonly IList<Assembly> _assemblies;
    private readonly IList<IModule> _modules;

    public Startup(IConfiguration configuration)
    {
        _assemblies = ModuleLoader.LoadAssemblies(configuration, "StockChart.Modules.");
        _modules = ModuleLoader.LoadModules(_assemblies);
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddModularInfrastructure(_assemblies, _modules);
        foreach (var module in _modules)
        {
            module.Register(services);
        }
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {
        logger.LogInformation($"Modules: {string.Join(", ", _modules.Select(x => x.Name))}");
        app.UseModularInfrastructure();
        foreach (var module in _modules)
        {
            module.Use(app);
        }

        // app.ValidateContracts(_assemblies);
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", context => context.Response.WriteAsync("StockCharts API"));
            endpoints.MapModuleInfo();
        });

        _assemblies.Clear();
        _modules.Clear();
    }
}