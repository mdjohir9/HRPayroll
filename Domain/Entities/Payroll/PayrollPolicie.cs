using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_Policies", Schema = "dbo")]
    public class PayrollPolicie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string? CompanyId { get; set; }

        public string? PolicyType { get; set; }

        public string? PolicyJson { get; set; }

        public string? PolicyCategory { get; set; }

        public bool IsActive { get; set; }
    }
}
