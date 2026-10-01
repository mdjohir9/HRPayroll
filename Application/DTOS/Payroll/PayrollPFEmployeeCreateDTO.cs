using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS.Payroll
{
    public class PayrollPFEmployeeCreateDTO
    {

        [Required]
        public string? EmployeeId { get; set; }
        [Required]
        public DateTime EmpJoiningDate { get; set; }
        [Required]
        public DateTime PFActivationDate { get; set; }

        public decimal? VoluntaryPercent { get; set; }
        [Required]
        public string CompanyId { get; set; } = string.Empty;
        [Required]
        public int PFPolicyId { get; set; }
    }
}
