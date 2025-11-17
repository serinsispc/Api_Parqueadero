using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V_CorreosClienteController : ControllerBase
    {
        [HttpPost("ConsultarIdCliente/{idcliente}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarIdCliente(int idcliente)
        {
            var db = HttpContext.Items["DB"];
            var resp = await V_CorreosCliente_controler.Lista_Cliente($"{db}",idcliente);
            return Ok(resp);
        }
    }
}
