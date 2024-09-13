using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WakeMapApi.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet("{name}")]
        public IActionResult Get([FromRoute] string name)
        {
            return Ok(_service.Get(name));
        }
    }
}
