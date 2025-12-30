using Newtonsoft.Json;
using SQL.Controler.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Procedures
{
    public class ConfiguracionDian_controler
    {
        public static async Task<List<ConfiguracionDian>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from ConfiguracionDian";
                var resp = await cn.EjecutarConsulta(db, query,true);
                var lista = JsonConvert.DeserializeObject<List<ConfiguracionDian>>(resp);
                return lista;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return new List<ConfiguracionDian>();
            }
        }
    }
}
