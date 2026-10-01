using Domain.Entities.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Payroll
{
    public class VatTaxIncomeTaxDetailsLog
    {
        public int Sl { get; set; }

        public string EmpId { get; set; } = null!;

        public DateOnly Month { get; set; }

        public double TaxAmount { get; set; }

        public string? TaxYears { get; set; }

        public bool? IsPaid { get; set; }

        public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
    }
}
