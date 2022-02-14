using System;

namespace StockCharts.Modules.Stocks.Core.Domain.Entities;

internal class Stock
{
    public Guid Id { get; private set; }
    public string Name { get; }
    public string Symbol { get; }
    public decimal Price { get; set; }
    public DateTime PriceLastUpdatedAt { get; set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; }

    private Stock()
    {
    }
    
    public Stock(Guid id, string name, string symbol)
    {
        Id = id;
        Name = name;
        Symbol = symbol;
        CreatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    public void SetPrice(decimal newPrice)
    {
        Price = newPrice;
        PriceLastUpdatedAt = DateTime.UtcNow;
    }

    public void Remove()
    {
        IsActive = false;
    }
}