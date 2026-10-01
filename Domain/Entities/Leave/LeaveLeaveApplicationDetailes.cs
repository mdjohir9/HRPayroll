using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Leave
{
    public class LeaveLeaveApplicationDetailes
    {
        [Key]
        [Required]
        public long ID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? EmpId { get; set; }

        public DateOnly? LeaveDate { get; set; }

        public int? LeaveApplicationID { get; set; }

        [ForeignKey(nameof(LeaveApplicationID))]
        public virtual Leave_LeaveApplications? Leave_LeaveApplications { get; set; }
    }
}
