using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class TblLeaveConfig
    {
        public int LeaveId { get; set; }

        public string? LeaveName { get; set; }

        public string? ShortName { get; set; }

        public int? LeaveDays { get; set; }

        public string? LeaveNature { get; set; }

        public bool? IsDeductionAllowed { get; set; }

        public string? CompanyId { get; set; }

        public virtual HrdCompanyInfo? Company { get; set; }
       // public virtual ICollection<LeaveLeaveApplication> LeaveLeaveApplications { get; set; } = new List<LeaveLeaveApplication>();
    }

}
