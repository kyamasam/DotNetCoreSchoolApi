using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Roster.Controllers
{
    [ApiController]
    [Route("")]
    public class DefaultController : Controller
    {
        private readonly ILogger<DefaultController> _logger;

        //constructor
        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public object Get()
        {
            var responseObject = new
            {
                Status = "Up",
                Other = "Other"
            };
            _logger.LogInformation($"Status Pinged: {responseObject.Status}");
            return responseObject;
        }
    

}
}