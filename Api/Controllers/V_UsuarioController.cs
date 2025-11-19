using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;
using SQL.Requests_Responses;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V_UsuarioController : ControllerBase
    {
        [HttpPost("ConsultarLogin")]
        [TokenDbFilter]
        public async Task<IActionResult> ConsultarLogin(V_Usuario_rr request)
        {
            var db = HttpContext.Items["DB"];
            var resp = await V_Usuario_controler.ConsultarUsuario($"{db}",request);
            return Ok(resp);
        }
    }
}
