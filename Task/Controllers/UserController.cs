using LogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogiLayerClass _logiLayerClass;
        public UserController(ILogiLayerClass logiLayerClass)
        {
            _logiLayerClass = logiLayerClass;
        }
        [HttpGet]
        [Route("GetData")]
        public IActionResult UserData()
        {
            return Ok(_logiLayerClass.actionresult());
        }

    }
}
