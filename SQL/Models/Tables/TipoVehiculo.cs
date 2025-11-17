using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class TipoVehiculo
    {
        public int id { get; set; }
        public string nombreTipoVehiculo { get; set; }
        public int estadoTipoVehiculo { get; set; }

        // Según tu preferencia actual: manejar imágenes como string (base64 o ruta)
        public string imagen { get; set; }
    }
}
