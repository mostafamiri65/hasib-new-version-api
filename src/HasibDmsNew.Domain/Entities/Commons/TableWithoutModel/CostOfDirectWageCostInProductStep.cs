namespace HasibDmsNew.Domain.Entities.Commons.TableWithoutModel
{
    public class CostOfDirectWageCostInProductStep
    {
        public int ProductStepId { get; set; }
        public int CostId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public int BranchId { get; set; }
        public decimal Completed { get; set; }
        public decimal AssignCapacity { get; set; }
        public decimal InflationPercentage { get; set; }
        public decimal MoneyUnitCoefficient { get; set; }
        public decimal Rate { get; set; }
        public decimal RealRate { get; set; }
        public decimal OneCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal RealOneCost { get; set; }
        public decimal RealTotalCost { get; set; }
    }
}
