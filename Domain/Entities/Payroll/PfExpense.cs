using Domain.Entities.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Payroll
{
    public class PfExpense
    {
        public int Sl { get; set; }

        public string EmpId { get; set; } = null!;

        public DateOnly Month { get; set; }

        public double Expense { get; set; }

        public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
    }
}
