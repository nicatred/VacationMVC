using DataAccess.Entites.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class VacationContext : IdentityDbContext<AppUser>
    {
        public VacationContext()
        {

        }
        public VacationContext(DbContextOptions<VacationContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=COMPUTER\NICATRED;Initial Catalog = Vacation; Trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<VacationRequest> VacationRequests { get; set; }
        public DbSet<VacationType> VacationTypes { get; set; }
    }
}
