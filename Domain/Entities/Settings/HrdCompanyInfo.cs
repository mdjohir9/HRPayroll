using Domain.Entities.Payroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class HrdCompanyInfo
    {
        public string CompanyId { get; set; } = null!;

        public bool? CompanyType { get; set; }

        public string? HeadOfficeId { get; set; }

        public string? CompanyName { get; set; }

        public string? CompanyNameBangla { get; set; }

        public string? Address { get; set; }

        public string? AddressBangla { get; set; }

        public string? Country { get; set; }

        public string? Telephone { get; set; }

        public string? Fax { get; set; }

        public string? DefaultCurrency { get; set; }

        public short? BusinessType { get; set; }

        public bool? MultipleBranch { get; set; }

        public string? Comments { get; set; }

        public string? CompanyLogo { get; set; }

        public short Id { get; set; }

        public string? StartCardNo { get; set; }

        public string? Weekend { get; set; }

        public string? ShortName { get; set; }

        public bool? CardNoType { get; set; }

        public short? FlatCode { get; set; }

        public short? CardNoDigits { get; set; }

        public string? AttMachineName { get; set; }

        public DateOnly? PfcountDate { get; set; }

        public bool? IsLeaveAuthority { get; set; }

        public bool? IsOdauthority { get; set; }
        public byte? Status { get; set; }
        public string? Email { get; set; }
        public virtual ICollection<PayrollAdvanceInfo> PayrollAdvanceInfo { get; set; } = new List<PayrollAdvanceInfo>();


        public virtual ICollection<PayrollBonusSetup> PayrollBonusSetups { get; set; } = new List<PayrollBonusSetup>();

        public virtual ICollection<TblHolydayWork> TblHolydayWorks { get; set; } = new List<TblHolydayWork>();

        public virtual ICollection<TblLeaveConfig> TblLeaveConfigs { get; set; } = new List<TblLeaveConfig>();
        public virtual ICollection<UserPackagesSetuped> UserPackagesSetups { get; set; } = new List<UserPackagesSetuped>();
        //public virtual ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<HRDCompanyStatusLog> HRDCompanyStatusLogs { get; set; } = new List<HRDCompanyStatusLog>();
    }
}
