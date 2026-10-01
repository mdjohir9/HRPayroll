using Application.DTOS.Payroll;
using Application.Repository;
using Domain.Entities.Payroll;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace CW_HRMS_API_Clean.Controllers.Payroll
{
    [Route("api/[controller]")]
    [ApiController]
    public class PFPolicyController : ControllerBase
    {
       // private readonly IUserRepository _userRepository;
        private readonly IMemoryCache _cache;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ApplicationDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PFPolicyController(IMemoryCache cache, IUnitOfWork unitOfWork, ApplicationDbContext dbContext, IHttpContextAccessor httpContextAccessor)
        {
            _cache = cache;
            _unitOfWork = unitOfWork;
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("pfPolicy{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var policy = await _unitOfWork.PFPolicy.GetByIdAsync(id);

                if (policy == null)
                    return NotFound(new { StatusCode = 404, Message = "Payroll PF policy not found." });

                return Ok(new { StatusCode = 200, Message = "Payroll PF policy retrieved successfully.", Data = policy });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error retrieving PF policy.", Details = ex.Message });
            }
        }

        [HttpGet("pfPolicyes")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var policies = await _unitOfWork.PFPolicy.GetAllAsync();

                if (policies == null || !policies.Any())
                    return NotFound(new { StatusCode = 404, Message = "No Payroll PF policies found." });

                return Ok(new { StatusCode = 200, Message = "Payroll PF policies retrieved successfully.", Data = policies });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error retrieving PF policies.", Details = ex.Message });
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] PayrollPFPolicyDTO dto)
        {
            try
            {
                if (dto == null || !ModelState.IsValid)
                    return BadRequest(new { StatusCode = 400, Message = "Invalid PF policy data." });

                var newPolicy = new PayrollPFPolicy
                {
                    PolicyName = dto.PolicyName,
                    ContributionType = dto.ContributionType,
                    EmployeeContributionPercent = dto.EmployeeContributionPercent,
                    EmployerContributionPercent = dto.EmployerContributionPercent,
                    EmployeeFixedAmount = dto.EmployeeFixedAmount,
                    EmployerFixedAmount = dto.EmployerFixedAmount,
                    CalculationBase = dto.CalculationBase,
                    WageLimit = dto.WageLimit,
                    IsActive = dto.IsActive,
                    CompanyId = dto.CompanyId
                };

                await _unitOfWork.PFPolicy.AddAsync(newPolicy);
                await _unitOfWork.Save();

                return Ok(new { StatusCode = 200, Message = "Payroll PF policy created successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error creating PF policy.", Details = ex.Message });
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PayrollPFPolicyDTO dto)
        {
            try
            {
                if (dto == null || !ModelState.IsValid)
                    return BadRequest(new { StatusCode = 400, Message = "Invalid PF policy data." });

                var existing = await _unitOfWork.PFPolicy.GetByIdAsync(id);
                if (existing == null)
                    return NotFound(new { StatusCode = 404, Message = "Payroll PF policy not found." });

                // ✅ Update fields
                existing.PolicyName = dto.PolicyName;
                existing.ContributionType = dto.ContributionType;
                existing.EmployeeContributionPercent = dto.EmployeeContributionPercent;
                existing.EmployerContributionPercent = dto.EmployerContributionPercent;
                existing.EmployeeFixedAmount = dto.EmployeeFixedAmount;
                existing.EmployerFixedAmount = dto.EmployerFixedAmount;
                existing.CalculationBase = dto.CalculationBase;
                existing.WageLimit = dto.WageLimit;
                existing.IsActive = dto.IsActive;
                existing.CompanyId = dto.CompanyId;

                await _unitOfWork.PFPolicy.UpdateAsync(existing);
                await _unitOfWork.Save();

                return Ok(new { StatusCode = 200, Message = "Payroll PF policy updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error updating PF policy.", Details = ex.Message });
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var existing = await _unitOfWork.PFPolicy.GetByIdAsync(id);
                if (existing == null)
                    return NotFound(new { StatusCode = 404, Message = "Payroll PF policy not found." });

                await _unitOfWork.PFPolicy.DeleteAsync(id);
                await _unitOfWork.Save();

                return Ok(new { StatusCode = 200, Message = "Payroll PF policy deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error deleting PF policy.", Details = ex.Message });
            }
        }
    }
}
