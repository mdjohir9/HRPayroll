using Domain.Entities.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Payroll
{
    public class PayrollBonusSetup
    {
        [Key] 
        public int Bid { get; set; }

        public string? CompanyId { get; set; }

        public string? BonusName { get; set; }

        public DateOnly? PaymentDate { get; set; }

        public DateOnly? ConfigDate { get; set; }

        public bool? Status { get; set; }

        public DateOnly? CalculationDate { get; set; }

        public short? Rid { get; set; }

        public virtual HrdCompanyInfo? Company { get; set; }
    }
}
