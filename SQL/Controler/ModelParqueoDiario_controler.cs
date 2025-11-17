using SQL.Controler.Tables;
using SQL.Controler.Views;
using SQL.Models;
using SQL.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Controler
{
    public class ModelParqueoDiario_controler
    {
        public static async Task<ModelParqueoDiario>Listas(string db)
        {
            try
            {
                var model=new ModelParqueoDiario();
                model.tipoVehiculos = await TipoVehiculo_controler.Lista(db);
                model.ListaVehiculosParqueados=await Motos_Diarias_controler.ListaParqueaderos(db);
                model.ListaMensualidad = await V_ClienteMensualidad_controler.Lista(db);
                model.listaDiasMensual = await DiasMensual_controler.Lista(db);
                model.ListaMensualidadNoche=await MensualidadNoche_controler.Lista(db);
                model.ListaVetados=await V_Vetados_controler.Lista("VehiculosVetados");
                model.ListaClienteEspecial=await ClienteEspecial_controler.Lista(db);
                model.listaTarifaDia=await TarifaDia_controler.Lista(db);
                model.listaTarifasVariables = await TarifasVariables_controler.Lista(db);
                model.listaResoluciones = await V_Resoluciones_controler.Lista(db);

                return model;
            }
            catch(Exception ex)
            {
                string msg = ex.Message;
                return new ModelParqueoDiario();
            }
        }
    }
}
