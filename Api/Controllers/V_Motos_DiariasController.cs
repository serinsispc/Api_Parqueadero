using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V_Motos_DiariasController : ControllerBase
    {
        // GET: api/V_Motos_Diarias
        [HttpPost("Consultar/{id}")]
        [TokenDbFilter]
        public async Task<IActionResult> Consultar(int id)
        {
            var db= HttpContext.Items["DB"]as string;
            var resp=await V_Motos_Diarias_controler.ConsultarID(db, id);
            return Ok(resp);
        }
    }
}
