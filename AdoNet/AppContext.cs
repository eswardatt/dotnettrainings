using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet
{
    class AppContext : DbContext
    {
        public AppContext()
            : base("name=MyConnection")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
