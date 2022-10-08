using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace dotnetCore_LineNotify.Controllers;

[ApiController]
[Route("[controller]")]
public class NotifyController : ControllerBase
{
    public string notifyToken { get; private set; } = "zlhtKgdZd2yLahxwy09IptEbCv8MhFXLnXUrBRZ435G";

    private readonly ILogger<NotifyController> _logger;

    public NotifyController(ILogger<NotifyController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Get()
    {
        string msg = "´ú¸Õªü!";
        isRock.LineNotify.Utility.SendNotify(notifyToken, msg);
        return Ok(msg);

    }

}
