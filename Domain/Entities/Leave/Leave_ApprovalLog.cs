using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Leave
{
    public class Leave_ApprovalLog
    {
        [Key]
        public int ID { get; set; }
        public byte Action { get; set; }
        public DateTime ActionTime { get; set; }
        public int ActionBy { get; set; }
        public Boolean IsSeen { get; set; }

        public int LeaveApplicationID { get; set; }

        [ForeignKey(nameof(LeaveApplicationID))]
        public virtual Leave_LeaveApplications? Leave_LeaveApplications { get; set; }
    }
}
