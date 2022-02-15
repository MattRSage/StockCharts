using System.Threading.Tasks;
using StockCharts.Modules.Stocks.Core.Exchanges.Entities;

namespace StockCharts.Modules.Stocks.Core.Exchanges.Repositories;

internal interface IExchangeRepository
{
    Task<Exchange> GetAsync(string symbol);
}