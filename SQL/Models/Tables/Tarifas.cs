using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class Tarifas
    {
        public int id { get; set; }
        public int idTipoVehiculo { get; set; }
        public int idFraccion { get; set; }
        public int idConvenio { get; set; }
        public int valor { get; set; }
    }

}
