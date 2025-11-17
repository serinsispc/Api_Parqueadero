using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class Motos_Diarias
    {
        public int IdMDiaria { get; set; }
        public DateTime FechaDia { get; set; }
        public DateTime HoraDia { get; set; }
        public int NumeroTiquete { get; set; }
        public int id_Tipovehiculo { get; set; }
        public string Placa { get; set; }
        public string Cascos { get; set; }
        public int id_EstadoVehiculo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime HoraSalida { get; set; }
        public int DiasTotales { get; set; }
        public int HorasTotales { get; set; }
        public int MinutosTotales { get; set; }
        public int segundosTotales { get; set; }
        public decimal valorTiempo { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public decimal Efectivo { get; set; }
        public decimal Cambio { get; set; }
        public int Contador { get; set; }
        public DateTime FechaPago { get; set; }
        public int idUsuario { get; set; }
        public int id_puesto_parqueo_diario { get; set; }
        public int tarifaMinutosTotal { get; set; }
        public int idBaseCaja { get; set; }
        public int numeroFactura { get; set; }
        public decimal valorIva { get; set; }
        public decimal costoCascos { get; set; }
        public string observacioParqueo { get; set; }
        public string numeroTargeta { get; set; }
        public int arqueoDia { get; set; }
        public decimal subtoal { get; set; }
        public string tipoFactura { get; set; }
        public string puestoCasco { get; set; }
        public int app { get; set; }
        public string appPC { get; set; }
        public Guid guidParqueo { get; set; }
        public int paquetero { get; set; }
        public int idMedioDePago { get; set; }

    }

}
