using StockCharts.Modules.Stocks.Application.Stocks.DTO;
using StockCharts.Shared.Abstractions.Queries;

namespace StockCharts.Modules.Stocks.Application.Stocks.Queries.Handlers;

public class BrowseStocksHandler : IQueryHandler<BrowseStocks, Paged<StockDto>>
{
    public Task<Paged<StockDto>> HandleAsync(BrowseStocks query, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}