namespace Domain.Entities.Payroll
{
    public class PayrollEnum
    {
        public enum CalculationMode { MONTH = 1, DAY = 2 }
        public enum SalaryBase { BASIC = 1, GROSS = 2 , FIXED = 3}
        public enum PolicyStatus { Inactive = 0, Active = 1 }
    }
}
