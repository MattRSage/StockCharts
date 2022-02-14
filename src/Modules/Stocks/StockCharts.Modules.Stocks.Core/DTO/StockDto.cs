using System;

namespace StockCharts.Modules.Stocks.Core.DTO;

public class StockDto
{
    public Guid StockId { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string MarketCap { get; set; }
    public decimal Price { get; set; }
}