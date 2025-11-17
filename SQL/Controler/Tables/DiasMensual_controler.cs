using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class DiasMensual_controler
    {
        public static async Task<List<DiasMensual>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from DiasMensual";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<DiasMensual>>(resp); }
                return new List<DiasMensual>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<DiasMensual>();
            }
        }
    }
}
