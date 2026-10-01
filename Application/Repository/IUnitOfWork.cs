using Application.Repository.Payroll;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        //Task<IDbContextTransaction> BeginTransactionAsync();

        Task<IDbContextTransaction> BeginTransactionAsync();

        IPFEmployeeRepository PFEmployee { get; }
        IPFPolicyRepository PFPolicy { get; }
        Task<int> Save();
       
    }
}
