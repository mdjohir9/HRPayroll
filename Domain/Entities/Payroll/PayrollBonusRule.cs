
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_BonusRule", Schema = "dbo")]
    public class PayrollBonusRule
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int EmpTypeId { get; set; }
        [Required]
        public string? CalculationMode { get; set; } // KeyWard :MONTH , DAY 
        public int? MinServiceValue { get; set; }
        public int? MaxServiceValue { get; set; }
        [Required]
        public string? ValueType { get; set; } //KeyWard : BASIC, GROSS , FIXED 
        [Required]
        public decimal? BonusValue { get; set; }
        public bool IsProrated { get; set; }

        [Required]
        public int PolicyId { get; set; }
        public PayrollBonusPolicy? Policy { get; set; }


    }
}
