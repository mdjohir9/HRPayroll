using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class UserPermission
    {
        [Required]
        [Key]
        public int UserPermId { get; set; }

        [Required(ErrorMessage = "Permission Name is required")]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string? PermissionName { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string? Url { get; set; }

        [StringLength(500)]
        [Column(TypeName = "nvarchar(500)")]
        public string? PhysicalLocation { get; set; }

        public int? Ordering { get; set; }
        public Boolean? IsActive { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }

        [Required]
        public int ModuleID { get; set; }
        [ForeignKey("ModuleID")]
        public virtual UserModule? UserModules { get; set; }
    }
}
