using System;
using System.Collections.Generic;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetSupplement
    {
        public BudgetSupplement()
        {
            Documents = new List<BudgetSupplementDocument>();
            Logs = new List<BudgetSupplementLog>();
        }

        public int Id { get; set; }
        public int FiscalYearId { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public byte Type { get; set; }
        public decimal Price { get; set; }
        public int MoneyUnitId { get; set; }
        public DateTime CreationTime { get; set; }
        public string Description { get; set; }
        public List<BudgetSupplementDocument> Documents { get; set; }
        public List<BudgetSupplementLog> Logs { get; set; }
    }
}
