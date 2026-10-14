namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetAllocate
    {
        public int Id { get; set; }
        public int BudgetNotificationId { get; set; }
        public decimal AllocatedBudget { get; set; }
        public int? WorkFlowStepActivityId { get; set; }
        public byte? WorkFlowStatus { get; set; }
    }
}
