using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_PFPolicy", Schema = "dbo")]
    public class PayrollPFPolicy
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? PolicyName { get; set; }

        public string ContributionType { get; set; } = "Percentage"; // Fixed 

        public decimal? EmployeeContributionPercent { get; set; } 
        public decimal? EmployerContributionPercent { get; set; } 

        public decimal? EmployeeFixedAmount { get; set; } 
        public decimal? EmployerFixedAmount { get; set; } 

        public string CalculationBase { get; set; } = "Basic"; //Basic , Gross

        public decimal? WageLimit { get; set; }
        public int? MinWorkingDays { get; set; }

        public bool IsActive { get; set; } = true;
        [Required]
        public string? CompanyId { get; set; }

        public ICollection<PayrollPFEmployee> PFEmployee { get; set; } = new List<PayrollPFEmployee>();
    }
}
