using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContadoresController : ControllerBase
    {
        [HttpPost("Contador")]
        [TokenDbFilter]
        public async Task<IActionResult> contador()
        {
            var db = HttpContext.Items["DB"];
            var resp = await Contadores_controler.Contador($"{db}");
            return Ok(resp);
        }
    }
}
