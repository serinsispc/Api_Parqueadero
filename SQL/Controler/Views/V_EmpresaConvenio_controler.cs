using Newtonsoft.Json;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Views
{
    public class V_EmpresaConvenio_controler
    {
        public static async Task<List<V_EmpresaConvenio>> Lista(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from V_EmpresaConvenio where estadoEmpresa=1";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if(resp != null)
                {
                    return JsonConvert.DeserializeObject<List<V_EmpresaConvenio>>(resp);
                }
                else
                {
                    return new List<V_EmpresaConvenio>();
                }
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new List<V_EmpresaConvenio>();
            }
        }
    }
}
