using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Models
{
    public class ConductorSolicitud
    {
        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public int idSolicitud { get; set; }
        public bool flagResponsable  { get; set;}
        public string nroCarnet { get; set;}
        public string telefono { get; set; }
        public string telefonoEmergencia { get; set; }
        public int idCompania  { get; set; }
        
    }
}
