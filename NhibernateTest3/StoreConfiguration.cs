using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;
using FluentNHibernate.Automapping;

namespace NhibernateTest3
{
    class StoreConfiguration : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "NhibernateTest3.DomainClasses";
        }
        //public override bool IsId(Member member)
        //{
        //    return member.Name == member.DeclaringType.Name + "Id";
        //}
    }
}
