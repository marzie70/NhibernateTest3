using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhibernateTest3.DomainClasses
{
    public class Shelf
    {
        public virtual Guid Id { get; set; }
        public virtual IList<Product> Products { get; set; }

        public Shelf()
        {
            Products = new List<Product>();
        }
    }
}
