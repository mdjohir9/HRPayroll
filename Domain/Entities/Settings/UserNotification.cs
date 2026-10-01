using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class UserNotification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string? UserIds { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string? Notification { get; set; }
        public bool? IsDone { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string? RefID { get; set; }

        public string? Type { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? CompanyId { get; set; }
    }
}
