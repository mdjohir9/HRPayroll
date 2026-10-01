using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class UserModule
    {
        [Required]
        [Key]
        public int ModuleID { get; set; }

        [Required(ErrorMessage = "Module Name is required")]
        [StringLength(160)]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100)]
        public string? ModuleName { get; set; }

        public int ParentID { get; set; }

        [Required(ErrorMessage = "Url is required")]
        [Column(TypeName = "nvarchar(500)")]
        [MaxLength(500)]
        public string? Url { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [MaxLength(500)]
        [Required(ErrorMessage = "Physical Location is required")]
        [StringLength(500)]
        public string? PhysicalLocation { get; set; }

        public bool IsActive { get; set; }
        public int Ordering { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50)]
        public string? IconClass { get; set; }

        public DateTime? CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
