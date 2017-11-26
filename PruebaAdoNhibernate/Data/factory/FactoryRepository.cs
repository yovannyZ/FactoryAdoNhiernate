using Entities;
using Ado = Data.ado.repository;
using NHiber = Data.nhibernate.repository;

namespace Data.factory
{
    public abstract class FactoryRepository
    {
        private static Ado.RegionRepository _instanceRegionAdo = null;
        private static NHiber.RegionRepository _instanceRegionNHibernate = null;
        //private static Ado.BaseRepository _instanceRegionAdo = null;
        private static NHiber.BaseRepository _instanceBaseNHibernate = null;

        public static IRepository<Region, int> GetInstanceRegion(Provider Provider)
        {
            switch (Provider)
            {
                case Provider.ADO:
                    if (_instanceRegionAdo == null)
                        _instanceRegionAdo = new Ado.RegionRepository();
                    return _instanceRegionAdo;
                case Provider.NHIBERNATE:
                    if (_instanceRegionNHibernate == null)
                        _instanceRegionNHibernate = new NHiber.RegionRepository();
                    return _instanceRegionNHibernate;
                default:
                    return null;
            }
        }
        public static IRepository<Base, int> GetInstanceBase(Provider Provider)
        {
            switch (Provider)
            {
                case Provider.ADO:
                   
                    return null;
                case Provider.NHIBERNATE:
                    if (_instanceBaseNHibernate == null)
                        _instanceBaseNHibernate = new NHiber.BaseRepository();
                    return _instanceBaseNHibernate;
                default:
                    return null;
            }
        }
    }
}
