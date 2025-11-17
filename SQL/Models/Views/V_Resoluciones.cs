using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Views
{
    public class V_Resoluciones
    {
        public int id { get; set; }
        public int idApi { get; set; }

        public string prefijo { get; set; }
        public string numeroResolucion { get; set; }

        public DateTime? fechaResolucion { get; set; }
        public DateTime? fechaFrom { get; set; }
        public DateTime? fechaTo { get; set; }

        public int fromResolucion { get; set; }
        public int toResolucion { get; set; }

        public int idCaja { get; set; }
        public string nombreResolucion { get; set; }

        public int consecutivo { get; set; }
        public int numeroActual { get; set; }

        public string EstadoConsecutivo { get; set; }
        public string EstadoResolucion { get; set; }

        public string token { get; set; }

        public int tax_detail_id { get; set; }
        public int idAmbiente { get; set; }
    }

}
