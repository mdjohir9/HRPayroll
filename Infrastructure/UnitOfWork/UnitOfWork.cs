using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Persistence;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Application.Repository;
using Infrastructure.Implementation.Payroll;
using Application.Repository.Payroll;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        private readonly IMemoryCache _cache;

        public UnitOfWork(
            ApplicationDbContext dbContext,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            IMemoryCache cache)
        {
            _dbContext = dbContext;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _cache = cache;

            // Payroll-specific repo must use PayrollDbContext
            PFEmployee = new PFEmployeeRepository(dbContext);
            PFPolicy = new PFPolicyRepository(dbContext);
        }
        public IPFEmployeeRepository PFEmployee { get; private set; }
        public IPFPolicyRepository PFPolicy { get; private set; }
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _dbContext.Database.BeginTransactionAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public Task<int> Save()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}
