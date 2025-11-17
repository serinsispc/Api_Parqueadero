using Newtonsoft.Json;
using SQL.Controler.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_Vetados_controler
    {
        public static async Task<List<V_Vetados>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_Vetados";
                var resp = await cn.EjecutarConsulta(db, query, true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<V_Vetados>>(resp); }
                return new List<V_Vetados>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<V_Vetados>();
            }
        }
    }
}
