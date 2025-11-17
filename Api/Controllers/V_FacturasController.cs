using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V_FacturasController : ControllerBase
    {
        [HttpPost("ConsultarID/{id}")]
        [TokenDbFilter]
        public async Task<IActionResult>ConsultarID(int id)
        {
            var db = HttpContext.Items["DB"];
            var resp = await V_Facturas_controler.ConsultarId($"{db}",id);
            return Ok(resp);
        }

        [HttpPost("ConsultarGUID/{guid}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarID(string guid)
        {
            var db = HttpContext.Items["DB"];
            var resp = await V_Facturas_controler.ConsultarGUID($"{db}", guid);
            return Ok(resp);
        }
    }
}
