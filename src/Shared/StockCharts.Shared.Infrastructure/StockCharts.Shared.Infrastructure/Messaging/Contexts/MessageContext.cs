using StockCharts.Shared.Abstractions.Contexts;
using StockCharts.Shared.Abstractions.Messaging;

namespace StockCharts.Shared.Infrastructure.Messaging.Contexts;

public class MessageContext : IMessageContext
{
    public Guid MessageId { get; }
    public IContext Context { get; }

    public MessageContext(Guid messageId, IContext context)
    {
        MessageId = messageId;
        Context = context;
    }
}