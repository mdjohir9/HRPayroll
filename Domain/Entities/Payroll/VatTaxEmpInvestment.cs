using Domain.Entities.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Payroll
{
    public class VatTaxEmpInvestment
    {
        public int Sl { get; set; }

        public string EmpId { get; set; } = null!;

        public string InvstYear { get; set; } = null!;

        public double? LifeInsurPremium { get; set; }

        public double? ContrDepositPensionScheme { get; set; }

        public double? InvstInApprSavingsCertificate { get; set; }

        public double? InvstInApprDebentureOrDebentureStockStockOrShares { get; set; }

        public double? ContrPfwhichPfact1925Applies { get; set; }

        public double? ContrSuperAnnuationFund { get; set; }

        public double? ContrBenevolentFundAndGroupInsurPremium { get; set; }

        public double? ContrZakatFund { get; set; }

        public double? Others { get; set; }

        public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
    }

}
