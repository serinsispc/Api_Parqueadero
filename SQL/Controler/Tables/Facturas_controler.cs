using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class Facturas_controler
    {
        public static async Task<Facturas>ConsultarGUID(string db,string guid)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Facturas where guidServicio=N'{guid}'";
                var resp = await cn.EjecutarConsulta(db,query);
                if (resp != null) { return JsonConvert.DeserializeObject<Facturas>(resp); }
                return new Facturas();
            }
            catch(Exception EX)
            {
                string ERROR = EX.Message;
                return new Facturas();
            }
        }

        public static async Task<Facturas> ConsultarID(string db, int id)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Facturas where id={id}";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null) { return JsonConvert.DeserializeObject<Facturas>(resp); }
                return new Facturas();
            }
            catch (Exception EX)
            {
                string ERROR = EX.Message;
                return new Facturas();
            }
        }

        public static async Task<int> ConsultarConsicutivo(string db, int idResolucion)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select Isnull(MAX(numeroFactura),0) from Facturas where idResolucion={idResolucion}";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null) { return JsonConvert.DeserializeObject<int>(resp); }
                return 0;
            }
            catch (Exception EX)
            {
                string ERROR = EX.Message;
                return 0;
            }
        }

        public static async Task<RespuestaCRUD> CRUD(string db,Facturas facturas,int boton)
        {
            try
            {
                var cn = new ConnectionSQL();
                string json = JsonConvert.SerializeObject(facturas);
                var query = $"EXEC CRUD_Facturas N'{json}',{boton}";
                var resp = await cn.EjecutarConsulta(db,query);
                return JsonConvert.DeserializeObject<RespuestaCRUD>(resp);
            }
            catch (Exception EX)
            {
                string ERROR = EX.Message;
                return new RespuestaCRUD();
            }
        }
    }
}
