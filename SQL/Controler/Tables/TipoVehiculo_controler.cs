using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class TipoVehiculo_controler
    {
        public static async Task<List<TipoVehiculo>>Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = "select *from TipoVehiculo";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) 
                {
                    return JsonConvert.DeserializeObject<List<TipoVehiculo>>(resp);
                }
                else
                {
                    return new List<TipoVehiculo>();
                }
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<TipoVehiculo>();
            }
        }
    }
}
