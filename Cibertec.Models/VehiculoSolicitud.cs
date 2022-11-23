using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Models
{
    public class VehiculoSolicitud
    {
        public string codigoVehiculo { get; set; }
        public string placa { get; set; }
        public string marca  { get; set;}
        public string modelo { get; set; }
        public int idSolicitud { get; set; }
        public int nroPasajeros { get; set; }
        public string nroSoat { get; set; }
        public int idCompania { get; set; }

    }
}
