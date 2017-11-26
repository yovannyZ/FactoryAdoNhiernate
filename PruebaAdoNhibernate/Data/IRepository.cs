using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<Entidad, Id>
    {
        IList<Entidad> ListarTodos();
        Entidad Obtener(Id id);
    }
}
