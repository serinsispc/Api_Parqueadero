using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class MensualidadNoche_controler
    {
        public static async Task<List<MensualidadNoche>>Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from MensualidadNoche";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<MensualidadNoche>>(resp); }
                return new List<MensualidadNoche>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<MensualidadNoche>();
            }
        }
    }
}
