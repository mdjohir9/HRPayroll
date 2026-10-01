using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_PFEmployees", Schema = "dbo")]
    public class PayrollPFEmployee
    {
        public int Id { get; set; }

        [Required] 
        public string? EmployeeId { get; set; } // FK to Employee
        [Required]
        public string? PFAccountNo { get; set; }
        [Required]
        public DateTime EmpJoiningDate { get; set; }

        [Required]
        public DateTime PfActivationDate { get; set; }
        public decimal? VoluntaryPercent { get; set; } // If employee wants more diposit Extra 
        [Required]
        public string? CompanyId { get; set; }

        // FK to PF Policy
        public int PFPolicyId { get; set; }
        public PayrollPFPolicy? PFPolicy { get; set; }
          
        public ICollection<PayrollPFTransaction> PFTransactions { get; set; } = new List<PayrollPFTransaction>();
        public ICollection<PayrollPFSettlement> PfSettlements { get; set; } = new List<PayrollPFSettlement>();
    }
}
