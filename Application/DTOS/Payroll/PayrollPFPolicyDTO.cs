using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS.Payroll
{
    public class PayrollPFPolicyDTO
    {
        public string PolicyName { get; set; } = string.Empty;
        public string ContributionType { get; set; } = "Percentage"; // "Percentage" or "Fixed"
        public decimal? EmployeeContributionPercent { get; set; }
        public decimal? EmployerContributionPercent { get; set; }
        public decimal? EmployeeFixedAmount { get; set; }
        public decimal? EmployerFixedAmount { get; set; }
        public string CalculationBase { get; set; } = "Basic";
        public decimal? WageLimit { get; set; }
        public bool IsActive { get; set; } = true;
        public string? CompanyId { get; set; }
    }
}
