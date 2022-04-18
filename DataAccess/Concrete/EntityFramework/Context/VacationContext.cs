using DataAccess.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class VacationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=COMPUTER\NICATRED;Initial Catalog = Vaction; Trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<VacationRequest> VacationRequests{ get; set; }
        public DbSet<VacationType> VacationTypes{ get; set; }
    }
}
