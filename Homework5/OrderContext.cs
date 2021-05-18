using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class OrderContext:DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(
              new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
