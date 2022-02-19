using Microsoft.EntityFrameworkCore;
using StockCharts.Modules.Stocks.Core.Exchanges.Entities;
using StockCharts.Modules.Stocks.Core.Exchanges.Repositories;

namespace StockCharts.Modules.Stocks.Infrastructure.EF.Repositories;

internal class ExchangeRepository : IExchangeRepository
{
    private readonly StocksDbContext _context;
    private readonly DbSet<Exchange> _exchanges;

    public ExchangeRepository(StocksDbContext context)
    {
        _context = context;
        _exchanges = context.Exchanges;
    }
    
    public Task<Exchange> GetAsync(string symbol) => _exchanges.SingleOrDefaultAsync(x => x.Symbol == symbol);

    public async Task AddAsync(Exchange exchange)
    {
        await _exchanges.AddAsync(exchange);
        await _context.SaveChangesAsync();
    }
}