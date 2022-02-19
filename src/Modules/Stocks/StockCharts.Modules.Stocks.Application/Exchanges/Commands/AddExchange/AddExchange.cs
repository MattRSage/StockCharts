using System.ComponentModel.DataAnnotations;
using StockCharts.Shared.Abstractions.Commands;

namespace StockCharts.Modules.Stocks.Application.Exchanges.Commands.AddExchange;

public record AddExchange([Required] string Name, [Required] string Symbol) : ICommand
{
    public Guid ExchangeId { get; init; } = Guid.NewGuid();
}