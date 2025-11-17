using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Tables;
using SQL.Models.Tables;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaElectronicaController : ControllerBase
    {
        [HttpPost("CRUD/{accion}")]
        [TokenDbFilter]
        public async Task<IActionResult> CRUD(int accion,FacturaElectronica factura)
        {
            var db = HttpContext.Items["DB"];
            var resp = await FacturaElectronica_controler.CRUD($"{db}",accion,factura);
            return Ok(resp);
        }

        [HttpPost("ConsultarCUFE/{cufe}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarCUFE(string cufe)
        {
            var db = HttpContext.Items["DB"];
            var resp = await FacturaElectronica_controler.ConsultarCUFE($"{db}", cufe);
            return Ok(resp);
        }
    }
}
