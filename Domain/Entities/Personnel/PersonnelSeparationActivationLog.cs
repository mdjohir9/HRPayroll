using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personnel
{
    public class PersonnelSeparationActivationLog
    {
        [Key]
        public int Sl { get; set; }

        public string? EmpId { get; set; }

        public long? EmpSeparationId { get; set; }

        public DateOnly? ActiveDate { get; set; }

        public string? Remark { get; set; }

        public int? UserId { get; set; }
    }
}
