using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Leave
{
    [Table("LeavePoliciesJoiningYears", Schema = "dbo")]

    public class LeavePoliciesJoiningYear
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? CompanyId { get; set; }

        public int? LeaveTypeId { get; set; }

        public string? Policy { get; set; }
    }
}
