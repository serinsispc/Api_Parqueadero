using Newtonsoft.Json;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_ClienteMensualidad_controler
    {
        public static async Task<List<V_ClienteMensualidad>>Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_ClienteMensualidad";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) 
                {
                    return JsonConvert.DeserializeObject<List<V_ClienteMensualidad>>(resp);
                }
                return new List<V_ClienteMensualidad>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<V_ClienteMensualidad>();
            }
        }
    }
}
