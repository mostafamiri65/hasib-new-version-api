namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetFinancialPayForm
    {
        public int OfferToPayItemId { get; set; }
        public int UserId { get; set; }
        public string SerialNumber { get; set; }
        public string User { get; set; }
        public string Subject { get; set; }
        public string Date { get; set; }
        public decimal Price { get; set; }
        public string FinancialUser { get; set; }
        public string OkCheckNumber { get; set; }
        public string OkDate { get; set; }
        public string OkBank { get; set; }
        public string OkAccount { get; set; }
        public string OkPrice { get; set; }
        public string OkSubject { get; set; }
        public string OkFinancialUser { get; set; }
        public string OkUser { get; set; }
    }
}
