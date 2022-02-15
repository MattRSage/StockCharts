using System;
using StockCharts.Modules.Stocks.Core.Exchanges.Types;
using StockCharts.Modules.Stocks.Core.Stocks.Types;
using StockCharts.Shared.Abstractions.Kernel.Types;

namespace StockCharts.Modules.Stocks.Core.Stocks.Entities;

internal class Stock : AggregateRoot<StockId>
{
    public ExchangeId ExchangeId { get; private set; }
    public string Name { get; }
    public string Symbol { get; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; }

    private Stock()
    {
    }
    
    public Stock(StockId id, ExchangeId exchangeId, string name, string symbol)
    {
        Id = id;
        ExchangeId = exchangeId;
        Name = name;
        Symbol = symbol;
        CreatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public void Remove()
    {
        IsActive = false;
    }
}