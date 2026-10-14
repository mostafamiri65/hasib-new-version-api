using System;

namespace HasibDmsNew.Domain.Entities.Costing.CostManager
{
    public class CostManagerProductSale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
