using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Repositories.BD_SAGESAD
{
    public interface IAreaRepository: IRepository<Area>
    {
        Area GetById(int id);

    }
}
