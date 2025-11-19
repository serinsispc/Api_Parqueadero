using Newtonsoft.Json;
using SQL.Models.Views;
using SQL.Requests_Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_Usuario_controler
    {
        public static async Task<V_Usuario>ConsultarUsuario(string db, V_Usuario_rr request)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_Usuario where cuenta_usuario='{request.user}' and clave_usuario='{request.password}'";
                var resp = await cn.EjecutarConsulta(db,query);
                if (resp != null) { return JsonConvert.DeserializeObject<V_Usuario>(resp); }
                return new V_Usuario();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new V_Usuario();
            }
        }
    }
}
