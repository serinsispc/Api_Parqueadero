using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class FacturaElectronica_controler
    {
        public static async Task<RespuestaCRUD>CRUD(string db, int accion,FacturaElectronica factura)
        {
            try
            {
                string json =JsonConvert.SerializeObject(factura);
                json = AjustarJSON.Ajustar(json);
                var cn = new ConnectionSQL();
                var query = $"exec CRUD_FacturaElectronica N'{json}',{accion}";
                var resp = await cn.EjecutarConsulta(db,query);
                return JsonConvert.DeserializeObject<RespuestaCRUD>(resp);
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new RespuestaCRUD { estado=false, idAfectado="0", mensaje="error", nuevoId="0" };
            }
        }

        public static async Task<FacturaElectronica> ConsultarCUFE(string db, string cufe)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from FacturaElectronica where cufe=N'{cufe}'";
                var resp = await cn.EjecutarConsulta(db, query);
                return JsonConvert.DeserializeObject<FacturaElectronica>(resp);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new FacturaElectronica();
            }
        }
    }
}
