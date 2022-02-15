using StockCharts.Shared.Infrastructure.Postgres;

namespace StockCharts.Modules.Stocks.Infrastructure.EF;

internal class StocksUnitOfWork : PostgresUnitOfWork<StocksDbContext>
{
    public StocksUnitOfWork(StocksDbContext dbContext) : base(dbContext)
    {
    }
}