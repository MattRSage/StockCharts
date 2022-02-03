using Microsoft.EntityFrameworkCore;
using StockCharts.Modules.Stocks.Core.Domain.Entities;

namespace StockCharts.Modules.Stocks.Core.DAL;

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