namespace HasibDmsNew.Domain.Entities.Strategics.Goals
{
    public class FiscalYearBranchGoalFormula
    {
        public long FiscalYearBranchGoalFormulaId { get; set; }

        public int FiscalYearId { get; set; }
        public int BranchId { get; set; }
        public int GoalTreeTitleId { get; set; }
    }
}
