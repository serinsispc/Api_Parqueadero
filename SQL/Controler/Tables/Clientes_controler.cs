using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class Clientes_controler
    {
        public static async Task<Clientes>ConsultarNit(string db,string nit)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select top 1 *from Clientes  where identificationNumber='{nit}'";
                var resp=await cn.EjecutarConsulta(db,query);
                if (resp != null) { return JsonConvert.DeserializeObject<Clientes>(resp); }
                return new Clientes();
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new Clientes();
            }
        }

        public static async Task<Clientes> ConsultarID(string db, int id)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select top 1 *from Clientes  where id={id}";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null) { return JsonConvert.DeserializeObject<Clientes>(resp); }
                return new Clientes();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new Clientes();
            }
        }
    }
}
