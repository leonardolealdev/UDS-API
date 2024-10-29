using Microsoft.AspNetCore.Mvc;
using UDS.Domain.Interfaces.Services;

namespace UDS_API.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _service;
        public PeopleController(IPeopleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Teste()
        {
            return Ok(await _service.List());
        }
    }
}
