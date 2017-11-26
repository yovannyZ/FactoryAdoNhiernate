using Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.nhibernate.mapping
{
    public class RegionMap : ClassMap<Region>
    {
        public RegionMap()
        {
            Id(x => x.Id).GeneratedBy.Identity().Column("IdRegion");
            Map(x => x.Codigo).Column("CoRegion");
            Map(x => x.Descripcion).Column("NoRegion");
            Map(x => x.DescCorta).Column("TxDescCorta");
            Map(x => x.EstaActivo).Column("FlActivo");
            Table("Region");
        }
    }
}
