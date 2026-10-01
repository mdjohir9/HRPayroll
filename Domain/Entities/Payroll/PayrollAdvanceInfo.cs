
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_AdvanceInfo", Schema = "dbo")]
    public class PayrollAdvanceInfo
    {
        [Key]
        public int Id { get; set; }

        public string? EmpId { get; set; }
        public string? CompanyId { get; set; }

        public decimal? AdvanceAmount { get; set; }
        public decimal? PaidAmount { get; set; }
        public decimal? InstallmentAmount { get; set; }

        public DateOnly? DeductFrom { get; set; }
        public int? PaidInstallmentNo { get; set; }

        public bool? IsPaid { get; set; }
        public bool? IsExemption { get; set; }
        public string? ExemptionReason { get; set; }
    

        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public bool? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DeletedReason { get; set; }

        public short? Status { get; set; }
        public string? StatusNote { get; set; }
        public DateOnly? StatusDate { get; set; }
        public DateTime? StatusUpdatedAt { get; set; }
        public int? StatusUpdatedBy { get; set; }

        public double? RefundAmount { get; set; }

        // Navigation - EF will detect required relationship automatically
        public ICollection<PayrollAdvanceDetails> AdvanceDetails { get; set; } = new List<PayrollAdvanceDetails>();
        public ICollection<PayrollAdvanceMonthlySetup> AdvanceMonthlySetup { get; set; } = new List<PayrollAdvanceMonthlySetup>();
    }
}
