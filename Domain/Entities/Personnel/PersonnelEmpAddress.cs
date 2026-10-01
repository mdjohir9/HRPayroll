using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personnel
{
    public class PersonnelEmpAddress
    {
        public string EmpId { get; set; } = null!;

        public string? PreVillage { get; set; }

        public string? PreVillageBangla { get; set; }

        public string? PrePo { get; set; }

        public string? PrePobangla { get; set; }

        public string? PrePostBox { get; set; }

        public int? PreThanaId { get; set; }

        public int? PreCity { get; set; }

        public string? PerVillage { get; set; }

        public string? PerVillageBangla { get; set; }

        public string? PerPo { get; set; }

        public string? PerPobangla { get; set; }

        public string? PerPostBox { get; set; }

        public int? PerThanaId { get; set; }

        public int? PerCity { get; set; }

        public string? MobileNo { get; set; }

        public string? Email { get; set; }

        public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
    }
}
