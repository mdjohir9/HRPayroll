using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_BonusPolicy", Schema = "dbo")]
    public class PayrollBonusPolicy
    {
        public int Id { get; set; }
        [Required]
        public string? CompanyId { get; set; }
        public string PolicyName { get; set; } = default!;
        public DateOnly EffectiveFrom { get; set; }
        public DateOnly? EffectiveTo { get; set; }
       // public PolicyStatus Status { get; set; } = PolicyStatus.Active;

        public ICollection<PayrollBonusRule> Rules { get; set; } = new List<PayrollBonusRule>();
    }
}
