using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public partial class TarifasVariables
    {
        public int id { get; set; }
        public int idTipoVehiculo { get; set; }
        public int inicio { get; set; }
        public int fin { get; set; }
        public decimal valorTarifa { get; set; }
        public int hi { get; set; }
        public int hf { get; set; }
        public int mi { get; set; }
        public int mf { get; set; }
        public int idCombenio { get; set; }
    }
}
