using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_PFSettlement", Schema = "dbo")]
    public class PayrollPFSettlement
    {
        public int Id { get; set; }
    
        public DateTime SettlementDate { get; set; }
        public decimal TotalBalance { get; set; }
        public string PaymentMode { get; set; } = "Bank Transfer"; // Or Cash/Cheque
        public string? Remarks { get; set; }
        [Required]
        public string? CompanyId { get; set; }

        public int EmployeeId { get; set; }
        public PayrollPFEmployee? EmployeePF { get; set; }

    }
}
