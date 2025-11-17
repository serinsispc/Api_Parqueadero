using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class Puesto_Parqueo_controler
    {
        public static async Task<List<Puesto_Parqueo>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Puesto_Parqueo";
                var resp = await cn.EjecutarConsulta(db, query, true);
                if (resp == null)
                {
                    return new List<Puesto_Parqueo>();
                }
                else
                {
                    return JsonConvert.DeserializeObject<List<Puesto_Parqueo>>(resp);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new List<Puesto_Parqueo>();
            }
        }
    }
}
