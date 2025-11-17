using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Tables;
using SQL.Models.Tables;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Motos_DiariasController : ControllerBase
    {
        [HttpPost("Lista")]
        [TokenDbFilter]
        public async Task<IActionResult> Lista()
        {
            var db = HttpContext.Items["DB"];
            var resp = await Motos_Diarias_controler.ListaParqueaderos($"{db}");
            return Ok(resp);
        }

        [HttpPost("ConsultarID/{id}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarID(int id)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Motos_Diarias_controler.ConsultarId($"{db}",id);
            return Ok(resp);
        }

        [HttpPost("CRUD/{accion}")]
        [TokenDbFilter]
        public async Task<IActionResult> CRUDP(int accion,Motos_Diarias model)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Motos_Diarias_controler.CRUD($"{db}", model,accion);
            return Ok(resp);
        }

        [HttpPost("ConsultarNumeroTiquete/{NumeroTiquete}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarNumeroTiquete(int NumeroTiquete)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Motos_Diarias_controler.ConsultarNumeroTiquete($"{db}", NumeroTiquete);
            return Ok(resp);
        }

        [HttpPost("ConsultarPLACA/{placa}")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarPLACA(string placa)
        {
            var db = HttpContext.Items["DB"];
            var resp = await Motos_Diarias_controler.ConsultarPLACA($"{db}", placa);
            return Ok(resp);
        }

        [HttpPost("HallarNumeroTK")]
        [TokenDbFilter]
        public async Task<IActionResult> HallarNumeroTK()
        {
            var db = HttpContext.Items["DB"];
            var resp = await Motos_Diarias_controler.HallarNumeroTiket($"{db}");
            return Ok(resp);
        }
    }
}
