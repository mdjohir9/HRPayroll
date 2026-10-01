using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_PFTransaction", Schema = "dbo")]
    public class PayrollPFTransaction
    {
        public int Id { get; set; }

        [Required]
        public DateTime TransactionMonth { get; set; }
        [Required]
        public decimal EmployeeContribution { get; set; }
        [Required]
        public decimal EmployerContribution { get; set; }

        public decimal TotalContribution => EmployeeContribution + EmployerContribution;

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public int? CreatedBy { get; set; }
        public DateTime? UpdateAt { get; set; } = DateTime.Now;
        public int? UpdateBy { get; set; } 
        public DateTime? DeletedAt { get; set; } = DateTime.Now;
        public int? DeletedBy { get; set; }
        public bool? IsManual { get; set; }
        [Required]
        public string? CompanyId { get; set; }

        [Required]
        public string? EmployeeId { get; set; }

        public PayrollPFEmployee? EmployeePF { get; set; }

    }
}
