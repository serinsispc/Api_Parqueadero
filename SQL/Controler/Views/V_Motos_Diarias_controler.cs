using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_Motos_Diarias_controler
    {
        public static async Task<Models.Views.V_Motos_Diarias> Consultar(string db,int id,int estado)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_Motos_Diarias where IdMDiaria={id} and id_EstadoVehiculo={estado}";
                var resp = await cn.EjecutarConsulta(db,query);
                if (resp != null) 
                { 
                    return JsonConvert.DeserializeObject<Models.Views.V_Motos_Diarias>(resp);
                }
                return new Models.Views.V_Motos_Diarias();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new Models.Views.V_Motos_Diarias();
            }
        }
        public static async Task<Models.Views.V_Motos_Diarias> ConsultarID(string db, int id)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_Motos_Diarias where IdMDiaria={id}";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null)
                {
                    return JsonConvert.DeserializeObject<Models.Views.V_Motos_Diarias>(resp);
                }
                return new Models.Views.V_Motos_Diarias();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new Models.Views.V_Motos_Diarias();
            }
        }
    }
}
