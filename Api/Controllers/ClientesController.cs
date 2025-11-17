using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Tables;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpPost("ConsultarNIT/{nit}")]
        [TokenDbFilter]
        public async Task<IActionResult>ConsultarNIT(string nit)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Clientes_controler.ConsultarNit($"{db}",nit);
            return Ok(resp);
        }

        [HttpPost("ConsultarID/{id}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarID(int id)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Clientes_controler.ConsultarID($"{db}", id);
            return Ok(resp);
        }
    }
}
