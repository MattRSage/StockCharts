using StockCharts.Modules.Stocks.Application.Stocks.DTO;
using StockCharts.Shared.Abstractions.Queries;

namespace StockCharts.Modules.Stocks.Application.Stocks.Queries;

public class BrowseStocks : PagedQuery<StockDto>
{
    public string State { get; set; }
}