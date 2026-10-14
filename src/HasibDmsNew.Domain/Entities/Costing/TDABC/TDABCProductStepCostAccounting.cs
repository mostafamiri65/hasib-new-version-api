namespace HasibDmsNew.Domain.Entities.Costing.TDABC
{
    public class TDABCProductStepCostAccounting
    {
        public int ProductStepId { get; set; }
        public int FiscalYearId { get; set; }
        public int PeriodId { get; set; }
        public decimal CapacityCost { get; set; }
        public decimal RealCost { get; set; }
        public decimal StaffCost { get; set; }
        public decimal DirectCost { get; set; }
        public decimal CapacityCostAccounting { get; set; }
        public decimal RealCostAccounting { get; set; }
        public decimal WholeCapacityCostAccounting { get; set; }
        public decimal WholeRealCostAccounting { get; set; }
    }
}
