using StockCharts.Shared.Abstractions.Exceptions;

namespace StockCharts.Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedNationalityException : StockChartsException
{
    public string Nationality { get; }

    public UnsupportedNationalityException(string nationality) : base($"Nationality: '{nationality}' is unsupported.")
    {
        Nationality = nationality;
    }
}