using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roster.Features.School;

namespace Roster.Controllers
{
    [Route("v1/api/roles")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        //method

        private readonly IMediator _mediator;

        public SchoolController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(Create.CreateSchoolCommand createSchoolCommands)
        {
            // make the cal

            var response = await _mediator.Send(createSchoolCommands);
            
            //handle the response

            return Ok(response);
        }
        
    }
}