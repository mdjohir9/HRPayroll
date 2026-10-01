using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Personnel
{
    public class PersonnelEmpCurrentStatus
    {
        [Key]  // ✅ Mark Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Sn { get; set; }

        public string? EmpId { get; set; }

        public string? PreCompanyId { get; set; }

        public string? CompanyId { get; set; }

        public string? EmpCardNo { get; set; }

        public int? PreEmpTypeId { get; set; }

        public int? EmpTypeId { get; set; }

        public string? PreSalaryType { get; set; }

        public string? SalaryType { get; set; }

        public double? EmpJoinigSalary { get; set; }

        public double? PreEmpSalary { get; set; }

        public double? EmpPresentSalary { get; set; }

        public double? PreIncrementAmount { get; set; }

        public double? IncrementAmount { get; set; }

        public double? PreBasicSalary { get; set; }

        public double? BasicSalary { get; set; }

        public double? PreMedicalAllownce { get; set; }

        public double? MedicalAllownce { get; set; }

        public double? PreFoodAllownce { get; set; }

        public double? FoodAllownce { get; set; }

        public double? PreConvenceAllownce { get; set; }

        public double? ConvenceAllownce { get; set; }

        public double? PreHouseRent { get; set; }

        public double? HouseRent { get; set; }

        public double? PreTechnicalAllownce { get; set; }

        public double? TechnicalAllownce { get; set; }

        public string? PreDptId { get; set; }

        public string? DptId { get; set; }

        public string? PreDsgId { get; set; }

        public string? DsgId { get; set; }

        public string? PreEmpStatus { get; set; }

        public string? EmpStatus { get; set; }

        public int? PreGrdId { get; set; }

        public int? GrdId { get; set; }

        public double? PreOthersAllownce { get; set; }

        public double? OthersAllownce { get; set; }

        public double? PreHolidayAllownce { get; set; }

        public double? HolidayAllownce { get; set; }

        public double? PreTiffinAllownce { get; set; }

        public double? TiffinAllownce { get; set; }

        public double? PreNightAllownce { get; set; }

        public double? NightAllownce { get; set; }

        public double? PreAttendanceBonus { get; set; }

        public double? AttendanceBonus { get; set; }

        public double? PreLunchAllownce { get; set; }

        public double? LunchAllownce { get; set; }

        public bool? LunchCount { get; set; }

        public DateOnly? DateofUpdate { get; set; }

        public string? TypeOfChange { get; set; }

        public string? EffectiveMonth { get; set; }

        public string? OrderRefNo { get; set; }

        public DateOnly? OrderRefDate { get; set; }

        public string? Remarks { get; set; }

        public bool? ActiveSalary { get; set; }

        public DateOnly? EarnLeaveDate { get; set; }

        public short? IsActive { get; set; }

        public DateTime? PreShiftTransferDate { get; set; }

        public DateTime? ShiftTransferDate { get; set; }

        public DateOnly? ShiftTransferToDate { get; set; }

        public string? SftId { get; set; }
        public int? UnitId { get; set; }

        public short? Gid { get; set; }

        public short? PreGid { get; set; }

        public bool? SalaryCount { get; set; }// not use it 

        public short? BankId { get; set; }

        public string? EmpAccountNo { get; set; }

        public bool? PfMember { get; set; }

        public DateOnly? PfDate { get; set; }

        public double? Pfamount { get; set; }

        public short? CustomOrdering { get; set; }

        public bool? OverTime { get; set; }

        public string? PreEmpDutyType { get; set; }

        public string? EmpDutyType { get; set; }

        public double? DormitoryRent { get; set; }

        public double? PreIncomeTax { get; set; }

        public double? IncomeTax { get; set; }

        public string? Tin { get; set; }

        public double? EmpContributionPer { get; set; }

        public double? EmpContributionAmount { get; set; }

        public double? EmprContributionPer { get; set; }

        public double? EmprContributionAmount { get; set; }

        public bool? IsSingleRateOt { get; set; }
        public DateOnly? IncrementMonth { get; set; }

        public DateOnly? PromotionMonth { get; set; }

        public bool? IsPromotion { get; set; }
        public bool? IsVacation { get; set; }

        public short? PayerBankId { get; set; }

        public DateOnly? UpdatedDate { get; set; }

        public DateOnly? CommonIncrementMonth { get; set; }

        public short? UpdateType { get; set; }
        public byte? PaymentMethod { get; set; }

        public DateTime? PromotionDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? ActivatedAt { get; set; }

        public virtual PersonnelEmployeeInfo? Emp { get; set; }
    }
}
