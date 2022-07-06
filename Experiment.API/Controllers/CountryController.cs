using Experiment.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Experiment.API.Models;
using System.Text.Json;

namespace Experiment.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        public CountryController(ILogger<CountryController> logger)
        {
            _logger = logger;
            _service = new Experiment.Data.Services.ListOfCountriesService();
        }

        private readonly ILogger<CountryController> _logger;
        private readonly ListOfCountriesService _service;

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] QueryStringParameters queryStringParameters)
        {
            IEnumerable<string> data = await _service.GetAllAsync();

            var pagedResult = PagedList<string>.ToPagedList<string>(data.AsQueryable(), queryStringParameters);
            var metadata = new
            {
                pagedResult.TotalCount,
                pagedResult.PageSize,
                pagedResult.CurrentPage,
                pagedResult.TotalPages,
                pagedResult.HasNext,
                pagedResult.HasPrevious
            };
            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));
            return Ok(pagedResult);
        }
    }
}