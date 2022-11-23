using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Models
{
    public class Compania
    {
        public int idCompania { get; set; }
        public string descripcion { get; set; }
        public char codigoUbigeo  { get; set;}
        public string ruc { get; set;}
        public bool flagCorporativo { get; set; }
    }
}
