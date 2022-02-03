namespace StockCharts.Shared.Abstractions.Exceptions;

public abstract class StockChartsException : Exception
{
    protected StockChartsException(string message) : base(message)
    {
    }
}