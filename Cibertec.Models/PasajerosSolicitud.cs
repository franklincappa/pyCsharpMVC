using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Models
{
    public class PasajerosSolicitud
    {
        public int idSolicitud { get; set; }
        public char tipoDocumento { get; set; }
        public string nroDocumento { get; set;}
        public int flagAsistencia { get; set; }
        public int idCompania { get; set; }


    }
}
