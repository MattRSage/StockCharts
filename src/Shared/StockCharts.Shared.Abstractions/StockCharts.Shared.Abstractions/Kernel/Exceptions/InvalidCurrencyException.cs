using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Shared.Abstractions.Kernel.Exceptions;

public class InvalidCurrencyException : StockChartsException
{
    public string Currency { get; }

    public InvalidCurrencyException(string currency) : base($"Currency: '{currency}' is invalid.")
    {
        Currency = currency;
    }
}