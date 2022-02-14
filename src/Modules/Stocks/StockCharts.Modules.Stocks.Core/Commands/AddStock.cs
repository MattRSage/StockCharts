using System;
using System.ComponentModel.DataAnnotations;
using StockCharts.Shared.Abstractions.Commands;

namespace StockCharts.Modules.Stocks.Core.Commands;

internal record AddStock([Required] string Name, [Required] string Symbol) : ICommand
{
    public Guid StockId { get; init; } = Guid.NewGuid();
}