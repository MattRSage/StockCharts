using StockCharts.Shared.Infrastructure.Postgres;

namespace StockCharts.Modules.Stocks.Core.DAL;

internal class StocksUnitOfWork : PostgresUnitOfWork<StocksDbContext>
{
    public StocksUnitOfWork(StocksDbContext dbContext) : base(dbContext)
    {
    }
}