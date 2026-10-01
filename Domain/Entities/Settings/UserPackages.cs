using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class UserPackages
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required(ErrorMessage = "PackageName is required ! please Insert PackageName")]
        [Column(TypeName = "nvarchar(100)")]
        [MaxLength(100, ErrorMessage = "Please insert PackageName value less than 100 characters.")]
        public string? PackageName { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        [Required(ErrorMessage = "Features is required ! please Select Features")]
        public string? Features { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Ordering is required ! please Insert Ordering")]
        public int Ordering { get; set; }
    }
}
