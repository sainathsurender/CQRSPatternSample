using CQRSWebAPI.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateSubjectCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetSubjectsQuery();
            var item = await _mediator.Send(query);
            return Ok(item);
        }
    }
}
