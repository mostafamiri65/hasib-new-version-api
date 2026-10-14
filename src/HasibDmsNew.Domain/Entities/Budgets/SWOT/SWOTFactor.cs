namespace HasibDmsNew.Domain.Entities.Budgets.SWOT
{
    public class SWOTFactor
    {
        public int SWOTFactorId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int SWOTMainFactorId { get; set; }
        public string SubFactorTitle { get; set; }
        public int SubjectCount { get; set; }
    }
}
