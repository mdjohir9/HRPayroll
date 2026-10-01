using Application.Repository.Payroll;
using Domain.Entities.Payroll;
using Infrastructure.Persistence;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation.Payroll
{
    public class PFEmployeeRepository : GenericRepository<PayrollPFEmployee>, IPFEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContextPayroll;

        public PFEmployeeRepository(ApplicationDbContext dbContextPayroll) : base(dbContextPayroll)
        {
            _dbContextPayroll = dbContextPayroll;
        }
    }
}
