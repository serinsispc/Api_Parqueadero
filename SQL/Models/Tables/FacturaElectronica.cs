using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class FacturaElectronica
    {
        public int id { get; set; }
        public int idFactura { get; set; }
        public string cufe { get; set; }
        public string numeroFactura { get; set; }
        public string fechaEmision { get; set; }
        public string fecahVensimiento { get; set; }
        public string imagenQR { get; set; }       // Puede ser base64 o URL
        public string dataQR { get; set; }
        public string archivoJson { get; set; }    // JSON original de la DIAN
        public int resolucion_id { get; set; }
        public string prefijo { get; set; }
        public int numero_factura { get; set; }
    }

}
