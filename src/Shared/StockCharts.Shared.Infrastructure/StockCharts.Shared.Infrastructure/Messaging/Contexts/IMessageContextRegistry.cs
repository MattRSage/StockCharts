using StockCharts.Shared.Abstractions.Messaging;

namespace StockCharts.Shared.Infrastructure.Messaging.Contexts;

public interface IMessageContextRegistry
{
    void Set(IMessage message, IMessageContext context);
}