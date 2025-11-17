using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Tables
{
    public class Puesto_Parqueo
    {
        public int id_puesto_parqueo { get; set; }
        public int numero_puesto { get; set; }
        public string tipo_puesto { get; set; }
        public int estado_puesto { get; set; }
    }

}
