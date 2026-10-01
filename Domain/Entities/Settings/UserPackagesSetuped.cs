using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class UserPackagesSetuped
    {
        [Key]
        [Required]
        public int PSID { get; set; }
        public string? CompanyId { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Features is required ! please Select Features")]
        public string? Features { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActivatedAt { get; set; }
        public DateTime? DeActivatedAt { get; set; }

        [Required]
        public int PackageId { get; set; }
        [ForeignKey("PackageId")]
        public virtual UserPackages? UserPackages { get; set; }

        public virtual HrdCompanyInfo HrdCompanyInfo { get; set; } = null!;
    }
}
