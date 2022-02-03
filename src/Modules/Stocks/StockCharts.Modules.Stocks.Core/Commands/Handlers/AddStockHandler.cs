using Microsoft.Extensions.Logging;
using StockCharts.Modules.Stocks.Core.Domain.Entities;
using StockCharts.Modules.Stocks.Core.Exceptions;
using StockCharts.Modules.Stocks.Core.Repositories;
using StockCharts.Shared.Abstractions.Commands;

namespace StockCharts.Modules.Stocks.Core.Commands.Handlers;

internal sealed class AddStockHandler : ICommandHandler<AddStock>
{
    private readonly IStockRepository _stockRepository;
    private readonly ILogger<AddStockHandler> _logger;

    public AddStockHandler(IStockRepository stockRepository, ILogger<AddStockHandler> logger)
    {
        _stockRepository = stockRepository;
        _logger = logger;
    }

    public async Task HandleAsync(AddStock command, CancellationToken cancellationToken = default)
    {
        var symbol = command.Symbol.ToUpperInvariant();

        var stock = await _stockRepository.GetAsync(symbol);
        if (stock is not null)
        {
            throw new StockAlreadyExistsException();
        }

        stock = new Stock(command.StockId, command.Name, command.Symbol);
        await _stockRepository.AddAsync(stock);
        _logger.LogInformation($"Stock with ID '{stock.Id}' has been added to the system.");
    }
}

