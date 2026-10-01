using Domain.Entities.Payroll;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.Payroll
{
    public interface IPFSettlementRepository : IGenericRepository<PayrollPFSettlement>
    {
        //Task<IEnumerable<PfBalanceDTO>> GetPfBalnaceAsync(string companyId);
    }
}
