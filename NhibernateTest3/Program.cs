using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhibernateTest3.DomainClasses;

namespace NhibernateTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var product = new Product
                    {
                        Name = "Cake",
                        Price = 400
                    };
                    var shelf = new Shelf();
                    {

                    };
                    session.Save(product);
                    transaction.Commit();
                    Console.WriteLine("Product Created: " + product.Name + "\t" + product.Price + "\t" + product.Id);
                }

                Console.ReadKey();
            }

        }
    }
}
