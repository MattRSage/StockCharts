using Microsoft.Extensions.Logging;
using StockCharts.Modules.Stocks.Core.Exchanges.Entities;
using StockCharts.Modules.Stocks.Core.Exchanges.Exceptions;
using StockCharts.Modules.Stocks.Core.Exchanges.Repositories;
using StockCharts.Shared.Abstractions.Commands;

namespace StockCharts.Modules.Stocks.Application.Exchanges.Commands.AddExchange;

internal sealed class AddExchangeHandler : ICommandHandler<AddExchange>
{
    private readonly IExchangeRepository _exchangeRepository;
    private readonly ILogger<AddExchangeHandler> _logger;

    public AddExchangeHandler(IExchangeRepository exchangeRepository, ILogger<AddExchangeHandler> logger)
    {
        _exchangeRepository = exchangeRepository;
        _logger = logger;
    }

    public async Task HandleAsync(AddExchange command, CancellationToken cancellationToken = default)
    {
        var symbol = command.Symbol.ToUpperInvariant();

        var exchange = await _exchangeRepository.GetAsync(symbol);

        if (exchange is not null)
        {
            throw new ExchangeAlreadyExistsException();
        }

        exchange = new Exchange(command.ExchangeId, command.Name, command.Symbol, DateTime.UtcNow);

        await _exchangeRepository.AddAsync(exchange);
        _logger.LogInformation("Exchange '{ExchangeName}' with ID '{ExchangeId}' has been added to the system",
            exchange.Name, exchange.Id.Value);
    }
}