using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class HRDCompanyStatusLog
    {
        [Key]
        [Required]
        public int LogId { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string? CompanyId { get; set; }

        [Required]
        [Range(0, 255)] // Equivalent to TINYINT
        public byte OldStatus { get; set; }

        [Required]
        [Range(0, 255)] // Equivalent to TINYINT
        public byte NewStatus { get; set; }

        [Required]
        public int ChangedBy { get; set; }

        [Required]
        public DateTime ChangedAt { get; set; } = DateTime.Now;

        [MaxLength(500)]
        public string? Remarks { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public virtual HrdCompanyInfo Company { get; set; } = null!;

    }
}
