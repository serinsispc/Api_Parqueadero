using Newtonsoft.Json;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_Resoluciones_controler
    {
        public static async Task<List<V_Resoluciones>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_Resoluciones";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) { return JsonConvert.DeserializeObject<List<V_Resoluciones>>(resp); }
                return new List<V_Resoluciones>();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<V_Resoluciones>();
            }
        }

        public static async Task<V_Resoluciones> ConsultarIdResolucion(string db,int idresolucion)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_Resoluciones where idApi={idresolucion}";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null) { return JsonConvert.DeserializeObject<V_Resoluciones>(resp); }
                return new V_Resoluciones();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new V_Resoluciones();
            }
        }
    }
}
