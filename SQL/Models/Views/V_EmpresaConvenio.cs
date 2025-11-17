using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL.Models.Views
{
    public class V_EmpresaConvenio
    {
        public int id { get; set; }
        public string nombreEmpresa { get; set; }
        public int estadoEmpresa { get; set; }
        public string estadotext { get; set; }
    }

}
