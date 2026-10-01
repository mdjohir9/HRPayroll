using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Payroll
{

    [Table("Payroll_SalaryStructure", Schema = "dbo")]
    public class Payroll_SalaryStructure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StructureId { get; set; }

        public string? CompanyId { get; set; }

        public byte? EmpTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? ComponentKey { get; set; }

        [Required]
        [MaxLength(20)]
        public string? CalculationType { get; set; }
        [MaxLength(50)]
        public string? PercentageOf { get; set; }

        public decimal? PercentageValue { get; set; }

        public decimal? FixedAmount { get; set; }

        public string? FormulaExpression { get; set; }

        public bool? IsEarning { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedAt { get; set; }

    }
}
