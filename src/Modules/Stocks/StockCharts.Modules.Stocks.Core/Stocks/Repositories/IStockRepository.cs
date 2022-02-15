using System;
using System.Threading.Tasks;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;

namespace StockCharts.Modules.Stocks.Core.Stocks.Repositories;

internal interface IStockRepository
{
    Task<Stock> GetAsync(Guid id);
    Task<Stock> GetAsync(string symbol);
    Task AddAsync(Stock stock);
}