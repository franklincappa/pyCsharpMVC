using Cibertec.Repositories.BD_SAGESAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.UnitOfWork
{
    interface IUnitOfWork
    {
        IAreaRepository Area { get; }
    }
}
