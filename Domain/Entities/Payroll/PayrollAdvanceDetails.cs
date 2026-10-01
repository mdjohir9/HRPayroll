
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_AdvanceDetails", Schema = "dbo")]
    public class PayrollAdvanceDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CompanyId { get; set; } = null!;

        // Required FK (non-nullable) → EF will set cascade delete
        [Required]
        public int AdvanceId { get; set; }

        [Required]
        public DateOnly AdvanceTakeDate { get; set; }

        public double? ParticularAmount { get; set; }
        public string? ParticularRemarks { get; set; }

        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public bool? IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public string? DeletedReason { get; set; }

        // Navigation
        public PayrollAdvanceInfo AdvanceInfo { get; set; } = null!;
    }
}
