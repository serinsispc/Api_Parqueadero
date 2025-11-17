using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Tables;
using SQL.Models.Tables;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensualidadNocheController : ControllerBase
    {
        [HttpPost("Lista")]
        [TokenDbFilter]
        public async Task<IActionResult> Lista()
        {
            var db = HttpContext.Items["DB"];
            var resp = await MensualidadNoche_controler.Lista($"{db}");
            return Ok(resp);
        }
    }
}
