using Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.nhibernate.mapping
{
    public class BaseMap : ClassMap<Base>
    {
        public BaseMap()
        {
            Id(x => x.Id).Column("Idzona");
            Map(x => x.Codigo).Column("CoZona");
            Map(x => x.Descripcion).Column("NoZona");
            Map(x => x.DescCorta).Column("TxDescCorta");
            Map(x => x.EstaActivo).Column("FlActivo");
            Table("Zona");

            References(x => x.Region)
                .LazyLoad(Laziness.False)
                .Column("IdRegion")
                .ForeignKey();

        }
    }
}
