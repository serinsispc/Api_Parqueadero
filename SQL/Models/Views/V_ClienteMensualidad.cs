using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Views
{
    public class V_ClienteMensualidad
    {
        public int Id_Mendualidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaRetirado { get; set; }

        public string tipoVeiculo { get; set; }
        public string Placa_Mendualidad { get; set; }
        public string NombreCliente_Mensualidad { get; set; }
        public string TelefonoCliente_Mensualidad { get; set; }
        public string EmpresaCliente_Mensualidad { get; set; }
        public string extadoCliente { get; set; }

        public DateTime fecha_inicio { get; set; }
        public int dias_mensualidad { get; set; }
        public DateTime fecha_fin { get; set; }
        public DateTime fecha_aviso { get; set; }

        public decimal valor_mensualidad { get; set; }
        public decimal valor_pagado { get; set; }
        public decimal valor_pendiente { get; set; }

        public string estado_mensualidad { get; set; }
        public string tipo_mensualidad { get; set; }

        public decimal subTotalMensualidad { get; set; }
        public decimal ivaMensualidad { get; set; }

        public int numeroFacturaActual { get; set; }

        public string estadoNoche { get; set; }
    }

}
