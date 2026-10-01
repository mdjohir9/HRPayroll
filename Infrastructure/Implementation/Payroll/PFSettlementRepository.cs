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
    public class PFSettlementRepository : GenericRepository<PayrollPFSettlement>, IPFSettlementRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public PFSettlementRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
