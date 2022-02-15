using Microsoft.EntityFrameworkCore;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;
using StockCharts.Modules.Stocks.Core.Stocks.Repositories;

namespace StockCharts.Modules.Stocks.Infrastructure.EF.Repositories;

internal class StockRepository : IStockRepository
{
    private readonly StocksDbContext _context;
    private readonly DbSet<Stock> _stocks;

    public StockRepository(StocksDbContext context)
    {
        _context = context;
        _stocks = context.Stocks;
    }

    public Task<Stock> GetAsync(Guid id) => _stocks.SingleOrDefaultAsync(x => x.Id == id);

    public Task<Stock> GetAsync(string symbol) => _stocks.SingleOrDefaultAsync(x => x.Symbol == symbol);

    public async Task AddAsync(Stock stock)
    {
        await _stocks.AddAsync(stock);
        await _context.SaveChangesAsync();
    }
}