using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class TarifaDia
    {
        public int id { get; set; }
        public int idTipoVehiculo { get; set; }
        public int idConvenio { get; set; }
        public decimal valorTarifa { get; set; }
        public int estado { get; set; }
    }
}
