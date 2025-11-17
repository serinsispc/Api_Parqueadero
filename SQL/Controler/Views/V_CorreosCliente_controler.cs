using Newtonsoft.Json;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_CorreosCliente_controler
    {
        public static async Task<List<V_CorreosCliente>> Lista_Cliente(string db, int idCliente)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_CorreosCliente idCliente={idCliente}";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<V_CorreosCliente>>(resp); }
                return new List<V_CorreosCliente>();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new List<V_CorreosCliente>();
            }
        }
    }
}
