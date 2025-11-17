using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class TarifasVariables_controler
    {
        public static async Task<List<TarifasVariables>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from TarifasVariables";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<TarifasVariables>>(resp); }
                return new List<TarifasVariables>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<TarifasVariables>();
            }
        }
    }
}
