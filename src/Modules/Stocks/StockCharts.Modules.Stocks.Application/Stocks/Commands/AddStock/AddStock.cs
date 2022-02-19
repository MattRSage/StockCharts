using System.ComponentModel.DataAnnotations;
using StockCharts.Shared.Abstractions.Commands;

namespace StockCharts.Modules.Stocks.Application.Stocks.Commands.AddStock;

internal record AddStock([Required] string Name, [Required] string Symbol, [Required] string ExchangeSymbol) : ICommand
{
    public Guid StockId { get; init; } = Guid.NewGuid();
}