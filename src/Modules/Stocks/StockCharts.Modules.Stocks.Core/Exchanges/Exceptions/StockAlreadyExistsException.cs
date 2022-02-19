using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Modules.Stocks.Core.Exchanges.Exceptions;

internal class ExchangeAlreadyExistsException : StockChartsException
{
    public ExchangeAlreadyExistsException() : base("Exchange already exists.")
    {
    }
}