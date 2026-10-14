namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetCorrectionSupplement
    {
        public int Id { get; set; }
        public int BudgetCorrectionId { get; set; }
        public byte Type { get; set; }
        public int SupplementId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Percent { get; set; }
    }
}
