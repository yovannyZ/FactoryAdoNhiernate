using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Entities;
using ado = Data.ado.repository;
using nHibernate = Data.ado.repository;
using Data.factory;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepository<Region, int> RegionRepository;
            IRepository<Base, int> BaseRepository;

            //LISTAMOS REGIONES CON ADO.NET
            RegionRepository =FactoryRepository.GetInstanceRegion(Provider.ADO);
            var lista = RegionRepository.ListarTodos();

            //LISTAMOS REGIONES CON NHIBERNATE
            RegionRepository = FactoryRepository.GetInstanceRegion(Provider.NHIBERNATE);
            lista = RegionRepository.ListarTodos();

            //LISTAMOS PUESTOS CON NHIBERNATE
            BaseRepository = FactoryRepository.GetInstanceBase(Provider.NHIBERNATE);
            var Bases = BaseRepository.ListarTodos();
        }
    }
}
