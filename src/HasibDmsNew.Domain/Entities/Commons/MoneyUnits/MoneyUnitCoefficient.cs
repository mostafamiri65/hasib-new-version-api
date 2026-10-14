namespace HasibDmsNew.Domain.Entities.Commons.MoneyUnits
{
    public class MoneyUnitCoefficient
    {
        public int MoneyUnitCoefficientId { get; set; }
        public int MoneyUnitId { get; set; }
        public int PeriodId { get; set; }
        public decimal Coefficient { get; set; }
    }
}
