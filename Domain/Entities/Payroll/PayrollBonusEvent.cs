
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("PayrollBonusEvent", Schema = "dbo")]
    public class PayrollBonusEvent
    {
        [Key]
        [Required]
        public int Id { get; set; }        

        [Required]
        public string? CompanyId { get; set; }     
        public string? EventName { get; set; }     
        [Required]
        public DateTime? BonusDate { get; set; }    
        public string? Remarks { get; set; }

        public bool? IsProcessed { get; set; }   

        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        [Required]
        public int? PolicyID { get; set; }
        public PayrollBonusPolicy? Policy { get; set; }
      //  public ICollection<PayrollYearlyBonusSheet> YearlyBonusSheet { get; set; }

    }
}
