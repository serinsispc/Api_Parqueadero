using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class ClienteEspecial_controler
    {
        public static async Task<List<ClienteEspecial>>Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from ClienteEspecial";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<ClienteEspecial>>(resp); }
                return new List<ClienteEspecial>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<ClienteEspecial>();
            }
        }
    }
}
