using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class HRDGrades
    {
        [Key]
        [Required]
        public int GradeID { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string? CompanyId { get; set; }

        [Required]
        public string? GrdName { get; set; }

        public string? GrdNameBangla { get; set; }

        [Required]
        public bool? GrdStatus { get; set; }

        [ForeignKey("CompanyId")]
        public virtual HrdCompanyInfo? HrdCompanyInfo { get; set; }
    }
}
