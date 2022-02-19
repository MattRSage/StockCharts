using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockCharts.Modules.Stocks.Application.Exchanges.Commands.AddExchange;
using StockCharts.Shared.Abstractions.Contexts;
using StockCharts.Shared.Abstractions.Dispatchers;
using Swashbuckle.AspNetCore.Annotations;

namespace StockCharts.Modules.Stocks.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ExchangesController : Controller
{
    private const string Policy = "exchanges";
    private readonly IDispatcher _dispatcher;
    private readonly IContext _context;

    public ExchangesController(IDispatcher dispatcher, IContext context)
    {
        _dispatcher = dispatcher;
        _context = context;
    }

    [HttpPost]
    [SwaggerOperation("Add exchange")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(AddExchange command)
    {
        await _dispatcher.SendAsync(command);
        return NoContent();
    }
}