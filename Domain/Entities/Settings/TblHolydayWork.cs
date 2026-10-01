using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Settings
{
    public class TblHolydayWork
    {
        public int Hcode { get; set; }

        public DateOnly Hdate { get; set; }

        public string? Description { get; set; }

        public string CompanyId { get; set; } = null!;

        public bool? IsOpen { get; set; }

        public virtual HrdCompanyInfo Company { get; set; } = null!;
    }
}
