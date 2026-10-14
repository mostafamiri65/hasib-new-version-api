namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class OfferToPayItem
    {
        public int Id { get; set; }
        public int WorkFlowStepActivityId { get; set; }
        public int OfferToPayId { get; set; }
        public OfferToPay OfferToPay { get; set; }
        public decimal Offer { get; set; }
    }
}
