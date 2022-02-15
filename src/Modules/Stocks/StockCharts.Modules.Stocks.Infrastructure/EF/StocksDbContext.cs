using Microsoft.EntityFrameworkCore;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;

namespace StockCharts.Modules.Stocks.Infrastructure.EF;

internal class StocksDbContext : DbContext
{
    public DbSet<Stock> Stocks { get; set; }

    public StocksDbContext(DbContextOptions<StocksDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("stocks");
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}