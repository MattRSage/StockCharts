using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockCharts.Modules.Stocks.Application.Stocks.Commands;
using StockCharts.Modules.Stocks.Application.Stocks.Commands.AddStock;
using StockCharts.Modules.Stocks.Application.Stocks.DTO;
using StockCharts.Modules.Stocks.Application.Stocks.Queries;
using StockCharts.Shared.Abstractions.Contexts;
using StockCharts.Shared.Abstractions.Dispatchers;
using StockCharts.Shared.Abstractions.Queries;
using Swashbuckle.AspNetCore.Annotations;

namespace StockCharts.Modules.Stocks.Api.Controllers;

[ApiController]
[Route("[controller]")]
internal class StocksController : Controller
{
    private const string Policy = "stocks";
    private readonly IDispatcher _dispatcher;
    private readonly IContext _context;

    public StocksController(IDispatcher dispatcher, IContext context)
    {
        _dispatcher = dispatcher;
        _context = context;
    }

    [HttpGet]
    [Authorize(Policy)]
    [SwaggerOperation("Browse stocks")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<ActionResult<Paged<StockDto>>> BrowseAsync([FromQuery] BrowseStocks query)
        => Ok(await _dispatcher.QueryAsync(query));

    [HttpPost]
    [SwaggerOperation("Add stock")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Post(AddStock command)
    {
        await _dispatcher.SendAsync(command);
        return NoContent();
    }
}