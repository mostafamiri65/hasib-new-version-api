namespace HasibDmsNew.Domain.Entities.Commons.Years
{
    public class FiscalYearBranchProcessFormula
    {
        public int FiscalYearBranchProcessFormulaId { get; set; }
        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int ProcessActivityAccountStructureId { get; set; }
    }
}
