using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Modules.Stocks.Core.Stocks.Exceptions;

internal class StockAlreadyExistsException : StockChartsException
{
    public StockAlreadyExistsException() : base("Stock already exists.")
    {
    }
}