using Newtonsoft.Json;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class Motos_Diarias_controler
    {
        public static async Task<List<Motos_Diarias>> ListaParqueaderos(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Motos_Diarias where id_EstadoVehiculo=1";
                var resp = await cn.EjecutarConsulta(db,query,true);
                if (resp != null) 
                { 
                    return JsonConvert.DeserializeObject<List<Motos_Diarias>>(resp.ToString());
                }
                return new List<Motos_Diarias>();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new List<Motos_Diarias>();
            }
        }

        public static async Task<Motos_Diarias> ConsultarId(string db, int id)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Motos_Diarias where IdMDiaria={id}";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null)
                {
                    return JsonConvert.DeserializeObject<Motos_Diarias>(resp.ToString());
                }
                return new Motos_Diarias();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new Motos_Diarias();
            }
        }

        public static async Task<RespuestaCRUD> CRUD(string db, Motos_Diarias P, int pEvento)
        {
            try
            {
                string json = JsonConvert.SerializeObject(P);
                json = AjustarJSON.Ajustar(json);
                var query = $"exec CRUD_Motos_Diarias '{json}',{pEvento}";
                var cn=new ConnectionSQL();
                var resp = await cn.EjecutarConsulta(db,query);
                return JsonConvert.DeserializeObject<RespuestaCRUD>(resp);
            }
            catch (Exception ex)
            {
                string Error = ex.Message;
                return new RespuestaCRUD { estado=false, idAfectado="0", mensaje="error", nuevoId="0" };
            }
        }


        public static async Task<Motos_Diarias> ConsultarNumeroTiquete(string db, int tiquete)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Motos_Diarias where NumeroTiquete={tiquete} and id_EstadoVehiculo=1";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null)
                {
                    return JsonConvert.DeserializeObject<Motos_Diarias>(resp.ToString());
                }
                return new Motos_Diarias();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new Motos_Diarias();
            }
        }

        public static async Task<Motos_Diarias> ConsultarPLACA(string db, string placa)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select *from Motos_Diarias where Placa ='{placa}' and id_EstadoVehiculo=1";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null)
                {
                    return JsonConvert.DeserializeObject<Motos_Diarias>(resp.ToString());
                }
                return new Motos_Diarias();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return new Motos_Diarias();
            }
        }
        public class  consecutivoTiket
        {
            public int Column1 { get; set; }
        }
        public static async Task<int> HallarNumeroTiket(string db)
        {
            try
            {
                var cn = new ConnectionSQL();
                var query = $"select isnull( MAX(NumeroTiquete),0) from Motos_Diarias";
                var resp = await cn.EjecutarConsulta(db, query);
                if (resp != null)
                {
                    return JsonConvert.DeserializeObject<consecutivoTiket>(resp).Column1;
                }
                return  0;
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                return 0;
            }
        }
    }
}
