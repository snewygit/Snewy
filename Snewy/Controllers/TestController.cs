using Microsoft.AspNetCore.Mvc;

namespace Snewy.Controllers;

[ApiController]
[Route("/")]
[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly ILogger<TestController> _logger;

    public TestController(ILogger<TestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get() => "Hello World";
}