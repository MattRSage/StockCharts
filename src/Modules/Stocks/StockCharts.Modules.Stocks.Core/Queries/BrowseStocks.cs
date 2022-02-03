using StockCharts.Modules.Stocks.Core.DTO;
using StockCharts.Shared.Abstractions.Queries;

namespace StockCharts.Modules.Stocks.Core.Queries;

public class BrowseStocks : PagedQuery<StockDto>
{
    public string State { get; set; }
}