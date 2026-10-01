using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_SalaryComponent", Schema = "dbo")]
    public class Payroll_SalaryComponent
    {
        [Key]
        [MaxLength(100)]
        public string ComponentKey { get; set; } = string.Empty; 

        [Required]
        [MaxLength(100)]
        public string ComponentName { get; set; } = string.Empty;

        public int OrderNo { get; set; } 

        public bool IsActive { get; set; } = true;

    }
}
