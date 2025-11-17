using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V_ResolucionesController : ControllerBase
    {
        [HttpPost("ConsultarIdResolucion/{idResolucion}")]
        [TokenDbFilter]
        public async Task<IActionResult>ConsultarIDResolucion(int idResolucion)
        {
            var db = HttpContext.Items["DB"];
            var resp = await V_Resoluciones_controler.ConsultarIdResolucion($"{db}", idResolucion);
            return Ok(resp);
        }
    }
}
