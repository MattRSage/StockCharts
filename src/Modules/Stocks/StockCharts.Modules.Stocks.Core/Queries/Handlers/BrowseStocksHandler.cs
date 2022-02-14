using System;
using System.Threading;
using System.Threading.Tasks;
using StockCharts.Modules.Stocks.Core.DTO;
using StockCharts.Shared.Abstractions.Queries;

namespace StockCharts.Modules.Stocks.Core.Queries.Handlers;

public class BrowseStocksHandler : IQueryHandler<BrowseStocks, Paged<StockDto>>
{
    public Task<Paged<StockDto>> HandleAsync(BrowseStocks query, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}