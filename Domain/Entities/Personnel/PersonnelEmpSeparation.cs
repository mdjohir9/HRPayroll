using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personnel
{
    public class PersonnelEmpSeparation
    {
        public long EmpSeparationId { get; set; }

        public string EmpId { get; set; } = null!;

        public string? EmpCardNo { get; set; }

        public DateOnly EffectiveDate { get; set; }

        public string? SeparationType { get; set; }

        public string? Remarks { get; set; }

        public int? EmpTypeId { get; set; }

        public DateOnly? EntryDate { get; set; }

        public bool? IsActive { get; set; }

        public int? UserId { get; set; }

        public bool? IsLastSeparation { get; set; }
        public string? CompanyId { get; set; } // 🔥 ADD THIS
    }
}
