using Application.DTOS.Payroll;
using Application.Repository;
using Domain.Entities.Payroll;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace CW_HRMS_API_Clean.Controllers.Payroll
{
    [Route("api/[controller]")]
    [ApiController]

    //test 

    public class PFEmployeeController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PFEmployeeController(IMemoryCache cache, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _cache = cache;
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("pfEmployee{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var employee = await _unitOfWork.PFEmployee.GetByIdAsync(id);

                if (employee == null)
                    return NotFound(new { StatusCode = 404, Message = "Payroll PF employee not found." });

                return Ok(new { StatusCode = 200, Message = "Payroll PF employee retrieved successfully.", Data = employee });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error retrieving PF employee.", Details = ex.Message });
            }
        }

//        [HttpGet]
//        [Route("allowPfEmployees")]
//        public async Task<IActionResult> GetEmployees([FromQuery] string CompanyId, [FromQuery] List<string>? DptIds, string? EmpCardNo,
//int? SftId, string? DeautyType, [FromQuery] List<string>? EmpTypeIds, [FromQuery] List<string>? UnitIds, DateOnly? JoiningStartDate, DateOnly? JoiningEndDate, bool onlyPFEligible)
//        {

//            try
//            {

//                var result = await _unitOfWork.PFEmployee.GetEligibleEmployeesByPolicyAsync(CompanyId, DptIds, EmpCardNo, SftId, DeautyType, EmpTypeIds, UnitIds, JoiningStartDate, JoiningEndDate, onlyPFEligible);

//                if (result == null || !result.Any())
//                {
//                    return NotFound(new { StatusCode = 404, message = "Employee not found!" });
//                }

//                return Ok(new { StatusCode = 200, message = "Success", data = result });

//            }
//            catch (KeyNotFoundException)
//            {
//                return NotFound(new { StatusCode = 404, message = "Employee not found!" });
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, new { StatusCode = 500, message = "An error occurred", error = ex.Message });
//            }
//        }




        [HttpGet("pfEmployees/{CompanyId}")]
        public async Task<IActionResult> GetAll(string CompanyId)
        {
            try
            {
                var employees = await _unitOfWork.PFEmployee.GetByCompanyIdAsync(CompanyId);

                if (employees == null || !employees.Any())
                    return NotFound(new { StatusCode = 404, Message = "No Payroll PF employees found." });

                return Ok(new { StatusCode = 200, Message = "Payroll PF employees retrieved successfully.", Data = employees });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error retrieving PF employees.", Details = ex.Message });
            }
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateMultiple([FromBody] List<PayrollPFEmployeeCreateDTO> dtoList)
        {
            try
            {
                if (dtoList == null || !dtoList.Any())
                    return BadRequest(new { StatusCode = 400, Message = "No PF employee data provided." });

                if (!ModelState.IsValid)
                    return BadRequest(new { StatusCode = 400, Message = "Invalid PF employee data." });

                // Map DTOs to Entities
                var newEmployees = dtoList.Select(dto => new PayrollPFEmployee
                {
                    EmployeeId = dto.EmployeeId,
                    PFAccountNo = "PF-" + Guid.NewGuid().ToString().Substring(0, 6), // Example unique default PF number
                    EmpJoiningDate = dto.EmpJoiningDate,
                    VoluntaryPercent = dto.VoluntaryPercent,
                    CompanyId = dto.CompanyId,
                    PFPolicyId = dto.PFPolicyId
                }).ToList();

                // Add multiple employees in one call
                await _unitOfWork.PFEmployee.AddRangeAsync(newEmployees);
                await _unitOfWork.Save();

                return Ok(new
                {
                    StatusCode = 200,
                    Message = "Payroll PF employees created successfully.",
                    Count = newEmployees.Count
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    StatusCode = 500,
                    Message = "Error creating multiple PF employees.",
                    Details = ex.Message
                });
            }
        }


        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] PayrollPFEmployeeCreateDTO dto)
        {
            try
            {
                if (dto == null || !ModelState.IsValid)
                    return BadRequest(new { StatusCode = 400, Message = "Invalid PF employee data." });

                var existing = await _unitOfWork.PFEmployee.GetByIdAsync(id);
                if (existing == null)
                    return NotFound(new { StatusCode = 404, Message = "Payroll PF employee not found." });

                // ✅ Update fields
                existing.EmployeeId = dto.EmployeeId;
                existing.EmpJoiningDate = dto.EmpJoiningDate;
                existing.PfActivationDate = dto.PFActivationDate;
                existing.VoluntaryPercent = dto.VoluntaryPercent;
                existing.CompanyId = dto.CompanyId;
                existing.PFPolicyId = dto.PFPolicyId;

                await _unitOfWork.PFEmployee.UpdateAsync(existing);
                await _unitOfWork.Save();

                return Ok(new { StatusCode = 200, Message = "Payroll PF employee updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error updating PF employee.", Details = ex.Message });
            }
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var existing = await _unitOfWork.PFEmployee.GetByIdAsync(id);
                if (existing == null)
                    return NotFound(new { StatusCode = 404, Message = "Payroll PF employee not found." });

                await _unitOfWork.PFEmployee.DeleteAsync(id);
                await _unitOfWork.Save();

                return Ok(new { StatusCode = 200, Message = "Payroll PF employee deleted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { StatusCode = 500, Message = "Error deleting PF employee.", Details = ex.Message });
            }
        }
    }
}
