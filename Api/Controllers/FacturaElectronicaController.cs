using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Tables;
using SQL.Controler.Views;
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
            if (resp.estado)
            {
                var retornar = await V_Facturas_controler.ConsultarId($"{db}",factura.idFactura);
                return Ok(retornar);
            }
            else
            {
                return BadRequest(resp);
            }
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
