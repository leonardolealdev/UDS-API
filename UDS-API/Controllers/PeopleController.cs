using Microsoft.AspNetCore.Mvc;
using UDS.Domain.Interfaces.Services;

namespace UDS_API.Controllers
{
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleService _service;
        public PeopleController(IPeopleService service)
        {
            _service = service;
        }


    }
}
