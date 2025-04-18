using Microsoft.AspNetCore.Mvc;
using woordenschat.Services.IServices;

namespace woordenschat.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class woordenController : ControllerBase
    {
        private readonly IWoordenService _woordenService;

        public woordenController(IWoordenService woordenService)
        {
            this._woordenService = woordenService;
        }

        [HttpGet]
        public IActionResult GetWoorden() {
            var woorden = _woordenService.Woorden();
            return Ok(woorden);
        }
    }
}