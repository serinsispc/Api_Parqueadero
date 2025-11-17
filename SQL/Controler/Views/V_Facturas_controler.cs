using Newtonsoft.Json;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_Facturas_controler
    {
        public static async Task<V_Facturas>ConsultarId(string db, int id)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select top 1 *from V_Facturas where id={id}";
                var resp = await cn.EjecutarConsulta(db,query);
                if (resp != null) { return JsonConvert.DeserializeObject<V_Facturas>(resp); }
                return new V_Facturas();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new V_Facturas();
            }
        }

        public static async Task<V_Facturas> ConsultarGUID(string db, string guid)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select top 1 *from V_Facturas where guidServicio=N'{guid}'";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null) { return JsonConvert.DeserializeObject<V_Facturas>(resp); }
                return new V_Facturas();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new V_Facturas();
            }
        }
    }
}
