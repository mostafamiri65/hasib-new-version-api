using System;

namespace HasibDmsNew.Domain.Entities.Budgets
{
    public class BudgetProposalSubDetail
    {
        public int Id { get; set; }
        public int BudgetProposalDetailId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte? Type { get; set; }
        public byte? ContractType { get; set; }
        public string ContractNumber { get; set; }
        public decimal? Count { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? AllPrice { get; set; }
        public decimal? Progress { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? PreviousYearAllocated { get; set; }
        public int? MoneyUnitId { get; set; }
        public int? BenchMarkId { get; set; }
        public byte? Priority { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public decimal? ConfirmCount { get; set; }
        public decimal? ConfirmUnitPrice { get; set; }
        public decimal? ConfirmAllPrice { get; set; }
        public decimal? ConfirmProgress { get; set; }
        public decimal? ConfirmTotalPrice { get; set; }
        public decimal? ConfirmPreviousYearAllocated { get; set; }
        public int? ConfirmCapitalCostCategoryId { get; set; }
        public int? ConfirmCostId { get; set; }
        public bool IsConfirmEntity { get; set; }
        public int? ConfirmResourcesId { get; set; }
        public int? ConfirmConsumptionId { get; set; }
        public string ConfirmDescription { get; set; }
    }
}
