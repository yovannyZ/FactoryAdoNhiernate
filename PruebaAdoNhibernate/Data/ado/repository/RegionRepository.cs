using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ado.repository
{
    public class RegionRepository : IRepository<Region, int> 
    {
        public IList<Region> ListarTodos()
        {
            List<Region> Lista = new List<Region>();
            string query = "ListarRegionTodos";

            using (SqlDataReader dr = DbHelper.ExecuteDataReaderProcedure(query))
            {
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Lista.Add(GetFromReader(dr));
                    }
                }

            }
            return Lista;
        }

        public Region Obtener(int id)
        {
            throw new NotImplementedException();
        }

        private Region GetFromReader(IDataReader dr)
        {//IdRegion, CoRegion, NoRegion, TxDescCorta, FlActivo
            Region region = new Region();
            region.Id = Convert.ToInt32(dr["IdRegion"]);
            region.Codigo = dr["CoRegion"].ToString();
            region.Descripcion = dr["NoRegion"].ToString();
            region.DescCorta = dr["TxDescCortaRegion"].ToString();
            region.EstaActivo = Convert.ToBoolean(dr["FlActivoRegion"]);
            return region;
        }
    }
}
