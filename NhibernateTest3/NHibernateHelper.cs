using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NhibernateTest3.DomainClasses;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace NhibernateTest3
{
    class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory(); return _sessionFactory;
            }
        }
        private static void InitializeSessionFactory()
        {
            var cfg = new StoreConfiguration();
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(@"Data Source=.;Initial Catalog=Employee;User ID=sa;Password=sa123")
                    .ShowSql()
                )
                .Mappings(m =>
                    m.AutoMappings
                        .Add(AutoMap.AssemblyOf<Product>(cfg)))
                .ExposeConfiguration(cfs => new SchemaExport(cfs)
                    .Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
