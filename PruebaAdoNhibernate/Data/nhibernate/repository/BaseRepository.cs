using Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.nhibernate.repository
{
    public class BaseRepository : IRepository<Base, int>
    {
        public IList<Base> ListarTodos()
        {
            using (ISession sesion = NHibernateHelper.OpenSession())
            {
                ICriteria busqueda;
                busqueda = sesion.CreateCriteria(typeof(Base));
                return busqueda.List<Base>();
            }
        }

        public Base Obtener(int id)
        {
            using (ISession sesion = NHibernateHelper.OpenSession())
            {
                return sesion.Get<Base>(id);
            }
        }
    }
}
