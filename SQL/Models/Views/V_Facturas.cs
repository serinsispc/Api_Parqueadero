using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Views
{
    public class V_Facturas
    {
        public int id { get; set; }
        public Guid guidFactura { get; set; }
        public Guid guidServicio { get; set; }
        public int idTIpoServicio { get; set; }
        public DateTime fecha { get; set; }
        public string tipoServicio { get; set; }
        public int idResolucion { get; set; }
        public int idApi { get; set; }
        public string nombreResolucion { get; set; }
        public string Dian { get; set; }
        public string prefijo { get; set; }
        public int numeroFactura { get; set; }
        public string numeroResolucion { get; set; }
        public DateTime fechaResolucion { get; set; }
        public DateTime fechaFrom { get; set; }
        public DateTime fechaTo { get; set; }
        public int fromResolucion { get; set; }
        public int toResolucion { get; set; }
        public decimal subTotal { get; set; }
        public decimal baseImpuesto { get; set; }
        public decimal valorIva { get; set; }
        public decimal Total { get; set; }
        public int estadoFactura { get; set; }
        public string detalle { get; set; }
        public string estaF { get; set; }
        public string cufe { get; set; }
        public string QRTexto { get; set; }
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public int? idImpuesto { get; set; }
        public int? idMedioDePago { get; set; }
        public string nombreMedioDePago { get; set; }
        public int idBaseCaja { get; set; }

    }
}
