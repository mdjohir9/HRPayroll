using Application.Repository;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CW_HRMS_API_Clean.Controllers.Payroll
{
    [Route("api/[controller]")]
    [ApiController]
    public class PFSettlementController : ControllerBase
    {
        //private readonly IUserRepository _userRepository;
        //private readonly IUserRepository _userRepository;
        //private readonly IUserRepository _userRepository;
        private readonly IMemoryCache _cache;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PFSettlementController(IMemoryCache cache, IUnitOfWork unitOfWork, ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _cache = cache;
            _unitOfWork = unitOfWork;
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
