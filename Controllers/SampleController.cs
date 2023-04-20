using Microsoft.AspNetCore.Mvc;

namespace AspNetCore7.Serilog.Demo.Controllers;

[Route("api/v1/sample")]
[ApiController]
public class SampleController : ControllerBase
{
    private readonly ILogger<SampleController> _logger;

    public SampleController(ILogger<SampleController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("This is from SampleController");
        return Ok();
    }
}