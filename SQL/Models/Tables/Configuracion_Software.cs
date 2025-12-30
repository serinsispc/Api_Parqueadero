using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class Configuracion_Software
    {
        public int id_configuracion { get; set; }

        public DateTime? fecha_creacion_configuracion { get; set; }
        public int? idusuario_creador { get; set; }

        public DateTime? fecha_modificacion { get; set; }
        public int? idusuario_modificacion { get; set; }

        public string nombre_empresa { get; set; }
        public string nit_empresa { get; set; }
        public string regimen_empresa { get; set; }
        public string telefono_empresa { get; set; }
        public string celular_empresa { get; set; }
        public string direccion_empresa { get; set; }
        public string representante_legal { get; set; }
        public string nombre_impresora { get; set; }
        public string tipo_impresora { get; set; }

        public int? tamaño_papel { get; set; }               // Si en SQL lo tienes como [tamaño_papel]
        public string tipo_cobro { get; set; }
        public string horarios_atencion { get; set; }
        public string leyenda_tiket_salida { get; set; }

        public string puestos_por_vahiculo { get; set; }     // char(1) -> string
        public string descuento_vendedor { get; set; }       // char(1)
        public string cliente_ocasional { get; set; }        // char(1)

        public string ruta_aplicacion_actualizacion { get; set; }
        public string ruta_carpeta_actualizacion { get; set; }
        public string logo_parqueadero { get; set; }
        public string logo_activo { get; set; }              // char(1)

        public int? idTipoTarifa { get; set; }
        public int? minutosDescuento1 { get; set; }
        public int? minutosDescuento2 { get; set; }
        public int? minutosDescuento3 { get; set; }

        public string correoAdmin1 { get; set; }
        public string correoAdmin2 { get; set; }

        public int? puestoCasco { get; set; }
        public int? cobroCasco { get; set; }
        public decimal? valorCobroCasco { get; set; }

        public int? tipoCodigoImpresora { get; set; }
        public int? tipoCodigoCajon { get; set; }
        public int? cortarPanel { get; set; }
        public int? targetas { get; set; }
        public int? copiFacturaParqueadero { get; set; }

        public string conexionInternet { get; set; }

        public int? tiketeCorto { get; set; }
        public int? activarCajon { get; set; }
    }
}
