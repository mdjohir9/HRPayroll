using Domain.Entities.Personnel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Leave
{
    public class Leave_LeaveApplications
    {
        [Key]
        //
        public int ID { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string? ApplicationId { get; set; } // form No 
        public int LeaveTypeId { get; set; }
        public Boolean IsHalfDayLeave { get; set; }
        public DateOnly ApplyDate { get; set; }
        public DateOnly LeaveStartDate { get; set; }
        public DateOnly LeaveEndDate { get; set; }
        public float TotalLeaveDays { get; set; }
        public DateOnly? PregnantDate { get; set; }
        public DateOnly? ExpectedDeliveryDate { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string? Remarks { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? HandedOverEmpId { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string? LvAddress { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? LvContact { get; set; }
        public Byte? ApprovalStatus { get; set; }
        public Byte? LeaveProcessingOrder { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string? CompanyId { get; set; }
        public string? Documment { get; set; }

        public int? EmpTypeId { get; set; }
        public int? SftId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? DptId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? DsgId { get; set; }
        public int? GId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? LeaveBalance { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string? EmpId { get; set; } = null;

        [ForeignKey(nameof(EmpId))]
        public virtual PersonnelEmployeeInfo? PersonnelEmployeeInfo { get; set; }

    }
}
