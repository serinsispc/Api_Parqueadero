using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class Facturas
    {
        public int id { get; set; }

        public Guid guidFactura { get; set; }

        public int idResolucion { get; set; }
        public int numeroFactura { get; set; }
        public int estadoFactura { get; set; }

        public Guid guidServicio { get; set; }
        public int idTIpoServicio { get; set; }

        public DateTime fecha { get; set; }

        public decimal totalServicio { get; set; }

        public string detalle { get; set; }

        public int idCliente { get; set; }

        public int idImpuesto { get; set; }

        public int idMedioDePago { get; set; }

        public int idBaseCaja { get; set; }
    }

}
