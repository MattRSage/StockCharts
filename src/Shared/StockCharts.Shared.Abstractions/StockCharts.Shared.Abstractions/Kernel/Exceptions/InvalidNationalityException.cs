using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Shared.Abstractions.Kernel.Exceptions;

public class InvalidNationalityException : StockChartsException
{
    public string Nationality { get; }

    public InvalidNationalityException(string nationality) : base($"Nationality: '{nationality}' is invalid.")
    {
        Nationality = nationality;
    }
}