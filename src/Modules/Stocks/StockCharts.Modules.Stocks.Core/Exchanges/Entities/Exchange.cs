using System;
using StockCharts.Modules.Stocks.Core.Exchanges.Types;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;
using StockCharts.Modules.Stocks.Core.Stocks.Types;

namespace StockCharts.Modules.Stocks.Core.Exchanges.Entities;

internal class Exchange
{
    public ExchangeId Id { get; private set; }
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }

    private Exchange()
    {
    }

    public Exchange(ExchangeId id, string name, DateTime createdAt)
    {
        Id = id;
        Name = name;
        IsActive = true;
        CreatedAt = createdAt;
    }

    public Stock AddStock(string name, string symbol)
    {
        return new Stock(new StockId(Guid.NewGuid()), this.Id, name, symbol);
    }
}