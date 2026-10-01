using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_AdvanceMonthlySetup", Schema = "dbo")]
    public class PayrollAdvanceMonthlySetup
    {
        [Key]
        public int Id { get; set; }

        // Required FK (non-nullable)
        [Required]
        public int AdvanceId { get; set; }

        [Required]
        public string EmpId { get; set; } = null!;

        [Required]
        public string CompanyId { get; set; } = null!;

        [Required]
        public DateOnly Month { get; set; }

        [Required]
        public decimal Amount { get; set; }

        public bool? IsPaid { get; set; }

        // Navigation
        public PayrollAdvanceInfo AdvanceInfo { get; set; } = null!;
    }
}
