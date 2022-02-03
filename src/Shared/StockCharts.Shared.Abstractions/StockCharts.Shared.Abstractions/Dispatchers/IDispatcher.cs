using Inflow.Shared.Abstractions.Events;
using StockCharts.Shared.Abstractions.Commands;
using StockCharts.Shared.Abstractions.Queries;

namespace StockCharts.Shared.Abstractions.Dispatchers;

public interface IDispatcher
{
    Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand;
    Task PublishAsync<T>(T @event, CancellationToken cancellationToken = default) where T : class, IEvent;
    Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default);
}