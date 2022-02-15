using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedCurrencyException : StockChartsException
{
    public string Currency { get; }

    public UnsupportedCurrencyException(string currency) : base($"Currency: '{currency}' is unsupported.")
    {
        Currency = currency;
    }
}