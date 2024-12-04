using Microsoft.AspNetCore.Mvc;

namespace API.Actions
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class ActionController : ControllerBase
    {
        private readonly IMediator _mediator;

        ActionController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public IActionResult<ICollection<Action>> GetActions()
        {
            var result = _mediator.Send(new GetAllActionsCommand());
            return Ok(result);
        }

    }
}
