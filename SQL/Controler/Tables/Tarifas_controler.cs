using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public  class Tarifas_controler
    {
        public static async Task<List<Tarifas>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Tarifas";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if(resp != null)
                {
                    return JsonConvert.DeserializeObject<List<Tarifas>>(resp);
                }
                else
                {
                    return new List<Tarifas>();
                }
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<Tarifas>();
            }
        }
    }
}
