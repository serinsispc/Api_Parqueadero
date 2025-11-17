using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelParqueoDiarioController : ControllerBase
    {
        [HttpPost("Model/Parqueadero")]
        [TokenDbFilter]
        public async Task<IActionResult> Listas()
        {
            var db = HttpContext.Items["DB"];
            var resp = await ModelParqueoDiario_controler.Listas($"{db}");
            return Ok(resp);
        }
    }
}
