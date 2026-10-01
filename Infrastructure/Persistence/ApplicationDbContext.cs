using Domain.Entities.Payroll;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PayrollPFEmployee> Payroll_PFEmployees { get; set; }
        public DbSet<PayrollPFPolicy> Payroll_PFPolicy { get; set; }
        public DbSet<PayrollPFTransaction> Payroll_PFTransaction { get; set; }
        public DbSet<PayrollPFSettlement> Payroll_PFSettlement { get; set; }

    }


}
