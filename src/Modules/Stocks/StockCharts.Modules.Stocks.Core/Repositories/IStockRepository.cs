using System;
using System.Threading.Tasks;
using StockCharts.Modules.Stocks.Core.Domain.Entities;

namespace StockCharts.Modules.Stocks.Core.Repositories;

internal interface IStockRepository
{
    Task<Stock> GetAsync(Guid id);
    Task<Stock> GetAsync(string symbol);
    Task AddAsync(Stock stock);
}