using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQL;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SQLController : ControllerBase
    {
        [HttpPost("execute-sql")]
        [TokenDbFilter]
        public async Task<IActionResult> ExecuteSql(ConsultaSQL json)
        {
            try
            {
                var db = HttpContext.Items["DB"] as string;
                var cn = new ConnectionSQL();
                var result = await cn.EjecutarConsulta(db, json.query, true);
                if (result == null) result = "[]";
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
