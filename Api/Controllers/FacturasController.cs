using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Tables;
using SQL.Controler.Views;
using SQL.Models.Tables;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        [HttpPost("Consultar/{guid}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarGUID(string guid)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Facturas_controler.ConsultarGUID($"{db}",guid);
            return Ok(resp);
        }

        [HttpPost("ConsultarID/{id}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarID(int id)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Facturas_controler.ConsultarID($"{db}", id);
            return Ok(resp);
        }

        [HttpPost("Consultar/Concedutivo/{idResolucion}")]
        [TokenDbFilter]
        public async Task<IActionResult> Concedutivo(int idResolucion)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Facturas_controler.ConsultarConsicutivo($"{db}", idResolucion);
            return Ok(resp);
        }

        [HttpPost("CRUD/{accion}")]
        [TokenDbFilter]
        public async Task<IActionResult> CRUDFactura(int accion,Facturas facturas)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Facturas_controler.CRUD($"{db}", facturas,accion);
            if(resp.estado)
            {
                int id = 0;
                if (resp.nuevoId =="")
                {
                    id = Convert.ToInt32(resp.idAfectado);
                }
                else
                {
                    id = Convert.ToInt32(resp.nuevoId);
                }
                var restornar=await V_Facturas_controler.ConsultarId($"{db}",id);
                return Ok(restornar);
            }
            else
            {
                return Ok(resp);
            }

        }
    }
}
