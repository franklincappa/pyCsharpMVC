using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Models
{
    public class SolicitudViaje
    {
        public int idSolicitud { get; set; }
        public string nroDocSolicitante { get; set; }
        public char tipoDocSolicitante { get; set;}
        public char tipoDocAprobador { get; set; }
        public string nroDocAprobador { get; set; }
        public DateTime fechaAprobacion { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public DateTime fechaRegistro { get; set; }
        public bool flagCheckList { get; set; }
        public DateTime fechaInicioViaje { get; set; }
        public DateTime fechaFinViaje { get; set; }
        public int idEstado { get; set; }
        public int idCompania { get; set; }
        public string motivo { get; set; }
        public string telefono { get; set; }
        public int tipoFlota { get; set; }
        public string codigoCuenta { get; set; }
        public char codigoUbigeoOrigen { get; set; }
        public int tipoSolicitud { get; set; }
        public string referencia { get; set; }
        public int idArea { get; set; }
    }
}
