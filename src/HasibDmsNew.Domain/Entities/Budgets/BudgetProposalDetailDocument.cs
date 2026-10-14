namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetProposalDetailDocument
    {
        public int Id { get; set; }
        public int BudgetProposalDetailId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public bool IsConfirmEntity { get; set; }
    }
}
