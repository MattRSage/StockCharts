using System;
using StockCharts.Shared.Abstractions.Kernel.Types;

namespace StockCharts.Modules.Stocks.Core.Stocks.Types;

public class StockId : TypeId
{
    public StockId() : this(Guid.NewGuid())
    {
    }
    
    public StockId(Guid value) : base(value)
    {
    }
    
    public static implicit operator StockId(Guid id) => new(id);
        
    public static implicit operator Guid(StockId id) => id.Value;
}