using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class ConfiguracionDian
    {
        public int id { get; set; }
        public int idAnbiente { get; set; }      // Ambiente DIAN (1 = pruebas, 2 = producción)
        public string token { get; set; }        // Token de autenticación
        public string textSetID { get; set; }    // SetID para documentos
        public string razonSocial { get; set; }  // Razón social
        public string nombreComercial { get; set; }
        public string nit { get; set; }
        public int idTipoContribuyente { get; set; }
        public int idRegiman { get; set; }       // Tipo de régimen
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    }
}
