using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Payroll
{
    [Table("Payroll_monthlysalarysheet_Compliances", Schema = "dbo")]
    public class Payroll_monthlysalarysheet_Compliance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Sl { get; set; }

        public string? CompanyId { get; set; }

        public string? SftId { get; set; }

        public string? EmpId { get; set; }

        public string? EmpCardNo { get; set; }

        public DateOnly? YearMonth { get; set; }

        public short? DaysInMonth { get; set; }

        public short? Activeday { get; set; }

        public short? WeekendHoliday { get; set; }

        public short? PayableDays { get; set; }

        public short? CasualLeave { get; set; }

        public short? SickLeave { get; set; }

        public short? AnnualLeave { get; set; }

        public short? OfficialLeave { get; set; }

        public short? OthersLeave { get; set; }

        public short? FestivalHoliday { get; set; }

        public short? AbsentDay { get; set; }

        public short? PresentDay { get; set; }

        public double? EmpPresentSalary { get; set; }

        public double? BasicSalary { get; set; }

        public double? HouseRent { get; set; }

        public double? MedicalAllownce { get; set; }

        public double? ConvenceAllownce { get; set; }

        public double? FoodAllownce { get; set; }

        public double? TechnicalAllowance { get; set; }

        public double? OthersAllownce { get; set; }

        public double? LunchAllowance { get; set; }

        public double? AdvanceDeduction { get; set; }

        public double? LoanDeduction { get; set; }

        public double? AbsentDeduction { get; set; }

        public double? AttendanceBonus { get; set; }

        public double? Payable { get; set; }

        public string? TotalOthour { get; set; }

        public double? Otrate { get; set; }

        public double? TotalOtamount { get; set; }

        public double? NetPayable { get; set; }

        public short? Stampdeduct { get; set; }

        public double? TotalSalary { get; set; }

        public string? DptId { get; set; }

        public string? DsgId { get; set; }

        public string? GrdName { get; set; }

        public short? EmpTypeId { get; set; }

        public string? EmpStatus { get; set; }

        public double? HoliDayBillAmount { get; set; }

        public double? NightbilAmount { get; set; }

        public double? TiffinBillAmount { get; set; }

        public int? UserId { get; set; }

        public short? IsSeperationGeneration { get; set; }

        public DateOnly? GenerateDate { get; set; }

        public double? ProvidentFund { get; set; }

        public double? ProfitTax { get; set; }

        public double? OthourForBuyer { get; set; }

        public double? OtamountForBuyer { get; set; }

        public double? ExtraOthour { get; set; }

        public double? ExtraOtamount { get; set; }

        public double? NetPayableWithAllOtamt { get; set; }

        public int? LateDays { get; set; }

        public double? LateFine { get; set; }

        public int? TiffinDays { get; set; }

        public double? TiffinTaka { get; set; }

        public int? HolidayWorkingDays { get; set; }

        public double? HolidayTaka { get; set; }

        public double? DormitoryRent { get; set; }

        public string? TotalOverTime { get; set; }

        public string? TotalOtherOverTime { get; set; }

        public double? OthersPay { get; set; }

        public double? OthersDeduction { get; set; }

        public short? ShortLeave { get; set; }

        public short? NightBillDays { get; set; }

        public double? EmpNetGross { get; set; }

        public DateOnly? FromDate { get; set; }

        public DateOnly? ToDate { get; set; }

        public int? Lwp { get; set; }

        public int? EmpSeparationId { get; set; }

        public string? OverTime { get; set; }

        public double? OverTimeAmount { get; set; }
    }
}
