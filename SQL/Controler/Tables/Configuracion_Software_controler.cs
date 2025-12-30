using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class Configuracion_Software_controler
    {
        public static async Task<Configuracion_Software> Consultar(string db)
        {
            try
            {
                var cn =new ConnectionSQL();
                var query = $"select top 1 *from Configuracion_Software";
                var data = await cn.EjecutarConsulta(db,query);
                var lista = Newtonsoft.Json.JsonConvert.DeserializeObject<Configuracion_Software>(data);
                if(lista != null)
                {
                    return lista;
                }
                else
                {
                    throw new Exception("No se encontró la configuración del software.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar la configuración del software: " + ex.Message);
            }
        }
    }
}
