using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personnel
{
    public class PersonnelEmpPersonnal
    {
        public int Sl { get; set; }

        public string EmpId { get; set; } = null!;

        public string? FatherName { get; set; }

        public string? MotherName { get; set; }

        public string? FatherNameBn { get; set; }

        public string? MotherNameBn { get; set; }

        public string? MaritialStatus { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public string? Age { get; set; }

        public string? PlaceOfBirth { get; set; }

        public string? Height { get; set; }

        public string? Weight { get; set; }

        public string? BloodGroup { get; set; }

        public string? Sex { get; set; }

        public string? LastEdQualification { get; set; }

        public string? NoOfExperience { get; set; }

        public string? Nationality { get; set; }

        public string? NationIdcardNo { get; set; }

        public short? NumberofChild { get; set; }

        public short? Rid { get; set; }

        public short? Qid { get; set; }

        public virtual PersonnelEmployeeInfo Emp { get; set; } = null!;
    }
}
