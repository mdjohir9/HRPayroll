using Domain.Entities.Personnel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Attendance
{
    public class TblEmpWiseWeekendinfo
    {
        public int Sl { get; set; }

        public string? CompanyId { get; set; }

        public string? DptId { get; set; }

        public short? Gid { get; set; }

        public string? DsgId { get; set; }

        public string EmpId { get; set; } = null!;

        public DateOnly Date { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
    }

}
