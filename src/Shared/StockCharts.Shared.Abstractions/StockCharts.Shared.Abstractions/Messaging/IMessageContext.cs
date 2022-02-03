using StockCharts.Shared.Abstractions.Contexts;

namespace StockCharts.Shared.Abstractions.Messaging;

public interface IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }
}