using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Shared.Abstractions.Kernel.Exceptions;

public class InvalidAmountException : StockChartsException
{
    public decimal Amount { get; }

    public InvalidAmountException(decimal amount) : base($"Amount: '{amount}' is invalid.")
    {
        Amount = amount;
    }
}