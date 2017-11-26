using Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.nhibernate.repository
{
    public class RegionRepository : IRepository<Region,int>
    {
        public IList<Region> ListarTodos()
        {
            using (ISession sesion = NHibernateHelper.OpenSession())
            {
                ICriteria busqueda;
                busqueda = sesion.CreateCriteria(typeof(Region));
                return busqueda.List<Region>();
            }
        }

        public Region Obtener(int id)
        {
            using (ISession sesion = NHibernateHelper.OpenSession())
            {
                return sesion.Get<Region>(id);
            }
        }
    }
}
