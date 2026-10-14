namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class FinancialStatementAdditionalInformation
    {
        public int FiscalYearId { get; set; }
        public decimal Tax { get; set; }
        public decimal SpecialInterest { get; set; }
        public decimal LegalReserve { get; set; }
        public decimal ReserveFund { get; set; }
        public decimal GovernmentDividends { get; set; }
        public decimal SourcesOfLosses { get; set; }
        public decimal UseOfYearsReserves { get; set; }
        public decimal DecreaseInCurrentAssets { get; set; }
        public decimal PublicResourcesOfGovernment { get; set; }
        public decimal Other { get; set; }
    }
}
