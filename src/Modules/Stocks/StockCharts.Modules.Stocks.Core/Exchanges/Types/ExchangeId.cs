using System;
using StockCharts.Shared.Abstractions.Kernel.Types;

namespace StockCharts.Modules.Stocks.Core.Exchanges.Types;

internal class ExchangeId : TypeId
{
    public ExchangeId() : this(Guid.NewGuid())
    {
    }
    
    public ExchangeId(Guid value) : base(value)
    {
    }
    
    public static implicit operator ExchangeId(Guid id) => new(id);
        
    public static implicit operator Guid(ExchangeId id) => id.Value;
}