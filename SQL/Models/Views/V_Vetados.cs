using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler.Tables
{
    public class V_Vetados
    {
        public int? id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Ciudad { get; set; }
        public string Parqueadero { get; set; }
        public string Tipo { get; set; }
        public string Placa { get; set; }
        public string Observación { get; set; }
    }
}
