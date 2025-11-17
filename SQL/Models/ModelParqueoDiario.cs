using SQL.Controler.Tables;
using SQL.Models.Tables;
using SQL.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models
{
    public class ModelParqueoDiario
    {
        public List<TipoVehiculo> tipoVehiculos { get; set; }

        public List<Motos_Diarias> ListaVehiculosParqueados { get; set; }

        public List<V_ClienteMensualidad> ListaMensualidad { get; set; }

        public List<DiasMensual> listaDiasMensual { get; set; }

        public List<MensualidadNoche> ListaMensualidadNoche { get; set; }
        public List<V_Vetados> ListaVetados { get; set; }
        public List<ClienteEspecial> ListaClienteEspecial { get; set; }
        public List<TarifaDia> listaTarifaDia { get; set; }
        public List<TarifasVariables> listaTarifasVariables { get; set; }
        public List<V_Resoluciones> listaResoluciones { get; set; }

    }
}
