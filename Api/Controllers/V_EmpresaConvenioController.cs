using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL.Controler.Views;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V_EmpresaConvenioController : ControllerBase
    {
        [HttpPost("Lista")]
        [TokenDbFilter]
        public async Task<IActionResult> Lista()
        {
            var db= HttpContext.Items["DB"];
            var resp = await V_EmpresaConvenio_controler.Lista($"{db}");
            return Ok(resp);
        }
    }
}
