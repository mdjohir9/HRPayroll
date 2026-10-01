using Domain.Entities.Attendance;
using Domain.Entities.Payroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personnel
{
    public class PersonnelEmployeeInfo
    {
        public int Sl { get; set; }

        public string EmpId { get; set; } = null!;

        public string? CompanyId { get; set; }

        public int? EmpTypeId { get; set; }

        public string? EmpName { get; set; }

        public string? NickName { get; set; }

        public string? EmpNameBn { get; set; }

        public string? EmpCardNo { get; set; }

        public string? EmpProximityNo { get; set; }

        public string? EmpStatus { get; set; }

        public TimeOnly? EmpStartLunch { get; set; }

        public TimeOnly? EmpEndLunch { get; set; }

        public string? EmpAccountNo { get; set; }

        public short? SftId { get; set; }

        public DateOnly? EmpShiftStartDate { get; set; }

        public DateOnly? EmpJoiningDate { get; set; }

        public string? GrdName { get; set; }

        public double? EmpJoinigSalary { get; set; }

        public bool? PfMember { get; set; }

        public DateOnly? PfDate { get; set; }

        public double? Pfamount { get; set; }

        public short? EarnedLeave { get; set; }

        public DateOnly? EarnedLeaveEffectedFrom { get; set; }

        public string? BonusType { get; set; }

        public string? EmpPicture { get; set; }

        public string? SignatureImage { get; set; }

        public string? SalaryCount { get; set; }

        public string? BankName { get; set; }

        public string? Type { get; set; }

        public string? WagesType { get; set; }

        public DateOnly? ExpireDate { get; set; }

        public string? RealProximityNo { get; set; }

        public bool? PunchType { get; set; }

        public bool? AuthorizedPerson { get; set; }

        public double? PfOpeningBalance { get; set; }

        public double? PfEmpContribution { get; set; }

        public bool? TiffinStatus { get; set; }

        public bool? NightBillStatus { get; set; }

        public bool? LunchBillStatus { get; set; }

        public bool? BreakfastStatus { get; set; }

        public bool? IsTransferredToCompliance { get; set; }

        public string? WeekendType { get; set; }
        public string? Weekend { get; set; }

        public virtual PersonnelEmpAddress? PersonnelEmpAddress { get; set; }

        public virtual PersonnelEmpPersonnal? PersonnelEmpPersonnal { get; set; }

        public virtual ICollection<PfExpense> PfExpenses { get; set; } = new List<PfExpense>();

        public virtual PfWithdraw? PfWithdraw { get; set; }

        public virtual ICollection<TblEmpWiseWeekendinfo> TblEmpWiseWeekendinfos { get; set; } = new List<TblEmpWiseWeekendinfo>();

        public virtual ICollection<VatTaxEmpInvestment> VatTaxEmpInvestments { get; set; } = new List<VatTaxEmpInvestment>();

        public virtual ICollection<VatTaxIncomeTaxDetailsLog> VatTaxIncomeTaxDetailsLogs { get; set; } = new List<VatTaxIncomeTaxDetailsLog>();
    }
}
