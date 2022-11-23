using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Repositories.BD_SAGESAD
{
    public interface ICompaniaRepository : IRepository<Compania>
    {
        Compania GetById(int id);

    }
}
