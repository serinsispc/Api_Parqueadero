using Newtonsoft.Json;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class Contadores_controler
    {
        public static async Task<Contadores> Contador(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Contadores";
                var resp = await cn.EjecutarConsulta(db,query);
                if (resp != null)
                {
                    return JsonConvert.DeserializeObject<Contadores>(resp);
                }
                else 
                {
                    return new Contadores { contador1 = 0, contador2 = 0, contador3 = 0, contador4 = 0 };
                }
            }
            catch (Exception ex) 
            {
                string msg = ex.Message;
                return new Contadores { contador1=0, contador2=0, contador3=0, contador4=0 };
            }
        }
    }
}
