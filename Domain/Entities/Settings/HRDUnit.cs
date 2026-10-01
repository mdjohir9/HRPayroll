using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class HRDUnit
    {
        [Key]
        [Required]
        public int UnitId { get; set; }
        [Required]
        public string? CompanyId { get; set; }

        [Required]
        [MaxLength(200)]
        public string? UnitName { get; set; }

        public string? UnitNameBn { get; set; }


        [MaxLength(20)]
        public string? UnitCode { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public int? CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public int? UpdatedBy { get; set; }
    }
}
