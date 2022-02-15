using Microsoft.Extensions.Logging;
using StockCharts.Modules.Stocks.Core.Exchanges.Repositories;
using StockCharts.Modules.Stocks.Core.Stocks.Entities;
using StockCharts.Modules.Stocks.Core.Stocks.Exceptions;
using StockCharts.Modules.Stocks.Core.Stocks.Repositories;
using StockCharts.Shared.Abstractions.Commands;

namespace StockCharts.Modules.Stocks.Application.Stocks.Commands.Handlers;

internal sealed class AddStockHandler : ICommandHandler<AddStock>
{
    private readonly IStockRepository _stockRepository;
    private readonly IExchangeRepository _exchangeRepository;
    private readonly ILogger<AddStockHandler> _logger;

    public AddStockHandler(IStockRepository stockRepository, ILogger<AddStockHandler> logger,
        IExchangeRepository exchangeRepository)
    {
        _stockRepository = stockRepository;
        _logger = logger;
        _exchangeRepository = exchangeRepository;
    }

    public async Task HandleAsync(AddStock command, CancellationToken cancellationToken = default)
    {
        var exchange = await _exchangeRepository.GetAsync(command.ExchangeSymbol);
        
        var symbol = command.Symbol.ToUpperInvariant();

        var stock = await _stockRepository.GetAsync(symbol);
        if (stock is not null)
        {
            throw new StockAlreadyExistsException();
        }

        stock = new Stock(command.StockId, exchange.Id, command.Name, command.Symbol);
        await _stockRepository.AddAsync(stock);
        _logger.LogInformation(
            "Stock '{StockName}' with ID '{StockId}' on '{ExchangeName}' Exchange has been added to the system",
            stock.Name, stock.Id.Value, exchange.Name);
    }
}